using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandria.Logic.Tile
{
    public interface ITile
    {
        int id { get; set; }
        int penalty { get; set; }
    }

    public class Tile : ITile
    {
        public int id { get; set; }
        public int penalty { get; set; }
    }
}
