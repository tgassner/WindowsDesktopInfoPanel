using System.Text.Json;
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
            //numWidth.Value = (decimal)_currentConfig.Width;
            //numHeight.Value = (decimal)_currentConfig.Height;
            //numTop.Value = (decimal)_currentConfig.Top;
            //numMargin.Value = (decimal)_currentConfig.RightMargin;
            //txtUrl.Text = _currentConfig.EspUrl;
            //txtColor.Text = _currentConfig.BackgroundColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Werte aus der UI zurück in das Objekt spielen
            //_currentConfig.Width = (double)numWidth.Value;
            //_currentConfig.Height = (double)numHeight.Value;
            //_currentConfig.Top = (double)numTop.Value;
            //_currentConfig.RightMargin = (double)numMargin.Value;
            //_currentConfig.EspUrl = txtUrl.Text;
            //_currentConfig.BackgroundColor = txtColor.Text;

            try
            {
                // JSON sauber formatiert (indented) zurückschreiben
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(_currentConfig, options);
                File.WriteAllText(_configPath, json);

                MessageBox.Show("Konfiguration erfolgreich gespeichert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
