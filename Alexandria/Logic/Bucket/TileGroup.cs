using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandria.Logic.Tile;

namespace Alexandria.Logic.Bucket
{
    public interface ITileGroup
    {
        ITile Tile { get; set; }
        int Quantity { get; set; }
    }

    public class TileGroup : ITileGroup
    {
        public ITile Tile { get; set; }
        public int Quantity { get; set; }
    }
}
