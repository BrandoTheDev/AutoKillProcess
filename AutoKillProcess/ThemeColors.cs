using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKillProcess
{
    internal class ThemeColors
    {
        public static Color DarkBackgroundColor { get; } = Color.FromArgb(30, 30, 30);
        public static Color DarkForegroundColor { get; } = Color.Black;   

        public static Color LightBackgroundColor { get; } = System.Drawing.SystemColors.Control;
        public static Color LightForegroundColor { get; } = System.Drawing.SystemColors.ControlText;
    }
}
