using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandria.Logic.Bucket
{
    public interface ITileGroupFactory : IFactory<ITileGroup>
    {
    }

    public class TileGroupFactory : ITileGroupFactory
    {
        public ITileGroup Create(string response)
        {
            TileGroup group = new TileGroup();
            String[] data = response.Split(',');

            group.Tile = new Tile.Tile();
            group.Quantity = Convert.ToInt32(data[2]);
            group.Tile.id = Convert.ToInt32(data[0]);
            if (data.Length > 3)
            {
                group.Tile.penalty = Convert.ToInt32(data[3]);
            }

            return group;
        }
    }
}
