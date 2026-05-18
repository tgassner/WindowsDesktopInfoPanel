using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsDesktopInfoPanelCommon
{
    public class AppConfig
    {
        public double Width { get; set; } = 300;
        public double Height { get; set; } = 200;
        public double Top { get; set; } = 40;
        public double RightMargin { get; set; } = 20;
        public string BackgroundColor { get; set; } = "#44000000";
        public string EspUrl { get; set; } = "http://192.168.x.x/data";
    }
}
