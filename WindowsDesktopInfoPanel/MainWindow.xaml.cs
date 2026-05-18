using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Timers;
using System.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using WindowsDesktopInfoPanelCommon;

namespace WindowsDesktopInfoPanel
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private static readonly HttpClient _httpClient = new HttpClient();
        private string _espUrl;

        // --- Win32 API Imports ---
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        public MainWindow()
        {
            InitializeComponent();

            // Positionierung: Oben Rechts
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width - 20;
            this.Top = 40;

            SetupTimers();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            LoadConfiguration();
            EmbedInDesktop();
        }

        private void LoadConfiguration()
        {
            // Pfad zur Datei im selben Ordner wie die exe
            string configPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

            if (File.Exists(configPath))
            {
                try
                {
                    string json = File.ReadAllText(configPath);
                    var config = JsonSerializer.Deserialize<AppConfig>(json);

                    if (config != null)
                    {
                        // Werte anwenden
                        this.Width = config.Width;
                        this.Height = config.Height;
                        this.Top = config.Top;
                        // Rechtsbündig berechnen:
                        this.Left = SystemParameters.PrimaryScreenWidth - config.Width - config.RightMargin;

                        // Den Hintergrund dynamisch setzen
                        var bc = new System.Windows.Media.BrushConverter();
                        this.MainBorder.Background = (System.Windows.Media.Brush)bc.ConvertFrom(config.BackgroundColor);

                        // URL für den ESP merken
                        _espUrl = config.EspUrl;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden der config.json: " + ex.Message);
                }
            }
            else
            {
                // Optional: Standarddatei erstellen, wenn sie nicht existiert
                var defaultConfig = new AppConfig();
                string json = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(configPath, json);
            }
        }

        private void EmbedInDesktop()
        {
            IntPtr windowHandle = new WindowInteropHelper(this).Handle;
            IntPtr progman = FindWindow("Progman", null);

            // 1. Sende Nachricht an Progman, um WorkerW zu erzeugen
            SendMessage(progman, 0x052C, new IntPtr(0), IntPtr.Zero);

            IntPtr workerW = IntPtr.Zero;

            // 2. Suche das WorkerW Fenster, das hinter den Icons liegt
            EnumWindows((hWnd, lParam) =>
            {
                IntPtr shellView = FindWindowEx(hWnd, IntPtr.Zero, "SHELLDLL_DefView", null);
                if (shellView != IntPtr.Zero)
                {
                    workerW = FindWindowEx(IntPtr.Zero, hWnd, "WorkerW", null);
                }
                return true;
            }, IntPtr.Zero);

            // 3. Setze unser Fenster als Kind von WorkerW
            if (workerW != IntPtr.Zero)
            {
                SetParent(windowHandle, workerW);
            }
        }

        private void SetupTimers()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += async (s, e) =>
            {
                TxtTime.Text = DateTime.Now.ToString("HH:mm");
                if (DateTime.Now.Second % 30 == 0) // Alle 30 Sek Sensoren laden
                {
                    await UpdateSensorData();
                }
            };
            _timer.Start();
        }

        private async Task UpdateSensorData()
        {
            try
            {
                var node = await _httpClient.GetFromJsonAsync<JsonNode>(_espUrl);

                if (node != null)
                {
                    TxtTemp.Text = $"{node["aussen_temperatur"]} °C";
                    TxtHum.Text = $"{node["aussen_luftfeuchte"]} %";
                }
            }
            catch { /* Fehlerbehandlung */ }
        }
    }
}