using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandria.Logic.Player;
using AzulServer;

namespace Alexandria.Logic.Turn
{
    public interface ITurnService
    {
        String CheckTurn(IPlayer player);
    }
    public class TurnService : ITurnService
    {
        public string CheckTurn(IPlayer player)
        {
            String response = Jogo.VerificarVez(player.id, player.password);
            if (response.StartsWith("ERRO")) throw new Exception(response);
            return response;
        }
    }
}
