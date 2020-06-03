using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandria.Logic
{
    public class Helper
    {
        public static Dictionary<int, Color> Colors { get; }
        public static Dictionary<Color, int> ColorId { get; }

        static Helper()
        {
            Colors = new Dictionary<int, Color>();
            ColorId = new Dictionary<Color, int>();

            Colors.Add(0, Color.LightSeaGreen);
            Colors.Add(1, Color.FromArgb(63, 136, 197));
            Colors.Add(2, Color.FromArgb(244, 157, 55));
            Colors.Add(3, Color.FromArgb(215, 38, 56));
            Colors.Add(4, Color.FromArgb(20, 15, 45));
            Colors.Add(5, Color.FromArgb(250, 250, 250));

            ColorId.Add(Color.LightSeaGreen, 0);
            ColorId.Add(Color.FromArgb(63, 136, 197), 1);
            ColorId.Add(Color.FromArgb(244, 157, 55), 2);
            ColorId.Add(Color.FromArgb(215, 38, 56), 3);
            ColorId.Add(Color.FromArgb(20, 15, 45), 4);
            ColorId.Add(Color.FromArgb(250, 250, 250), 5);
        }
    }
}
