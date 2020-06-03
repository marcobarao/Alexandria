using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandria.Logic.Player;

namespace Alexandria.Logic.Turn
{
    public interface ITurnFactory
    {
        ITurn Create(String response, List<IPlayer> players);
    }
    class TurnFactory : ITurnFactory
    {
        public ITurn Create(string response, List<IPlayer> players)
        {
            Turn turn = null;
            response = response.Trim();

            if (response != String.Empty)
            {
                String[] data = response.Split(',');

                int id = Convert.ToInt32(data[1]);

                turn = new Turn();
                turn.Player = players.Find(iterator => iterator.id == id);
            }

            return turn;
        }
    }
}
