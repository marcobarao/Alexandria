using System;
using AzulServer;

namespace Alexandria.Logic.Match
{
    public interface IMatchService
    {
        String FindByStatus(MatchStatus status);
        String CreateMatch(IMatch match);

        String ListPlayers(IMatch match);
    }
    public class MatchService: IMatchService
    {
        public String FindByStatus(MatchStatus status)
        {
            String response = Jogo.ListarPartidas(status.ToString());
            if (response.StartsWith("ERRO")) throw new Exception(response);
            return response;
        }

        public String CreateMatch(IMatch match)
        {
            String response = Jogo.CriarPartida(match.name, match.password);
            if (response.StartsWith("ERRO")) throw new Exception(response);
            return response;
        }

        public string ListPlayers(IMatch match)
        {
            String response = Jogo.ListarJogadores(match.id);
            if (response.StartsWith("ERRO")) throw new Exception(response);
            return response;
        }
    }
}
