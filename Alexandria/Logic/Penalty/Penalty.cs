using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandria.Logic.Penalty
{
    public interface IPenalty
    {
        Color color { get; set; }
        int penalty { get; set; }
    }

    public class Penalty : IPenalty
    {
        public Color color { get; set; }
        public int penalty { get; set; }
    }
}
