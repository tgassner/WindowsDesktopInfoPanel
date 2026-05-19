using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsDesktopInfoPanelCommon
{
    public class AppConfig
    {
        public int Width { get; set; } = 380;
        public int Height { get; set; } = 260;
        public int Top { get; set; } = 10;
        public int RightMargin { get; set; } = 10;
        public string BackgroundColor { get; set; } = "#44000000";
        public string EspUrl { get; set; } = "http://www.intern/smarthome/json.php";
    }
}
