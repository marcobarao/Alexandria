using System;
using System.Collections.Generic;
using Alexandria.Logic.Match;
using AzulServer;

namespace Alexandria.Logic.Player
{
    public interface IPlayerService
    {
        String JoinMatch(IMatch match, string name, string password);
    }

    class PlayerService : IPlayerService
    {
        public string JoinMatch(IMatch match, string name, string password)
        {
            String response = Jogo.EntrarPartida(match.id, name, password);
            if (response.StartsWith("ERRO")) throw new Exception(response);
            return response;
        }
    }
}
