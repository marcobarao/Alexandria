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
            String data = response.Trim();
            if (data != String.Empty)
            {
                int id = Convert.ToInt32(response);

                turn = new Turn();
                turn.player = players.Find(iterator => iterator.id == id);
            }

            return turn;
        }
    }
}
