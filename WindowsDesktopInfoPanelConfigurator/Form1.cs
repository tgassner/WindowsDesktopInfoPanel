using System.Text.Json;
using Microsoft.Win32;
using WindowsDesktopInfoPanelCommon;

namespace WindowsDesktopInfoPanelConfigurator
{
    public partial class Form1 : Form
    {
        private readonly string _configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        private AppConfig _currentConfig;

        public Form1()
        {
            InitializeComponent();
            LoadConfigIntoUi();
        }

        private void LoadConfigIntoUi()
        {
            if (File.Exists(_configPath))
            {
                try
                {
                    string json = File.ReadAllText(_configPath);
                    _currentConfig = JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Lesen der Config: {ex.Message}");
                    _currentConfig = new AppConfig();
                }
            }
            else
            {
                _currentConfig = new AppConfig();
            }

            // UI-Elemente befüllen
            numWidth.Value = _currentConfig.Width;
            numHeight.Value = _currentConfig.Height;
            numTop.Value = _currentConfig.Top;
            numMargin.Value = _currentConfig.RightMargin;
            txtUrl.Text = _currentConfig.EspUrl;
            txtColor.Text = _currentConfig.BackgroundColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Werte aus der UI zurück in das Objekt spielen
            _currentConfig.Width = (int)numWidth.Value;
            _currentConfig.Height = (int)numHeight.Value;
            _currentConfig.Top = (int)numTop.Value;
            _currentConfig.RightMargin = (int)numMargin.Value;
            _currentConfig.EspUrl = txtUrl.Text;
            _currentConfig.BackgroundColor = txtColor.Text;
            _currentConfig.ShowTime = checkBoxShowTime.Checked;
            _currentConfig.ShowDate = checkBoxShowDate.Checked;

            try
            {
                // JSON sauber formatiert (indented) zurückschreiben
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(_currentConfig, options);
                File.WriteAllText(_configPath, json);

                MessageBox.Show("Konfiguration erfolgreich gespeichert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSetAutostart_Click(object sender, EventArgs e)
        {
            try
            {
                // Pfad zur Registry-Node für den aktuellen Benutzer
                using RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (key != null)
                {
                    // Pfad zur WPF-Hauptanwendung ermitteln
                    // Da beide EXEs im selben BuildOutput-Ordner liegen, tauschen wir einfach den Dateinamen
                    string wpfExePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WindowsDesktopInfoPanel.exe");

                    if (File.Exists(wpfExePath))
                    {
                        // Eintrag in die Registry schreiben (Name des Eintrags, Pfad zur EXE)
                        key.SetValue("WindowsDesktopInfoPanel", $"\"{wpfExePath}\"");

                        MessageBox.Show("Autostart erfolgreich eingerichtet!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Die Datei 'WindowsDesktopInfoPanel.exe' wurde im aktuellen Verzeichnis nicht gefunden.\n" +
                                        "Bitte stelle sicher, dass beide Programme im selben Ordner liegen.",
                            "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Schreiben in die Registry: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveAutostart_Click(object sender, EventArgs e)
        {
            try
            {
                using RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (key != null)
                {
                    // Prüfen, ob der Eintrag überhaupt existiert
                    if (key.GetValue("WindowsDesktopInfoPanel") != null)
                    {
                        // Eintrag löschen
                        key.DeleteValue("WindowsDesktopInfoPanel");
                        MessageBox.Show("Autostart erfolgreich entfernt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Es war kein Autostart-Eintrag vorhanden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Löschen aus der Registry: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
