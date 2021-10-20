using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagement
{
    public static class ThemColor
    {
        public static Color primaryColor { get; set; }
        public static Color secondColor { get; set; }
        public static List<string> ColorList = new List<string>()
        {                                              "#FF0000",
                                                        "#800000",
                                                        "#808000",
                                                        "#00FF00",
                                                        "#008000",
                                                        "#008080",
                                                        "#0000FF",
                                                        "#000080",
                                                        "#FF00FF",
                                                        "#800080"
        };
        public static Color ChangeColorBrithness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red=(255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A,(byte)red,(byte)green,(byte)blue);
        }
}
}
