using System;
using Alexandria.Logic.Match;
using AzulServer;

namespace Alexandria.Logic.Player
{
    public interface IPlayerService
    {
        String JoinMatch(IMatch match, String name, String password);
        String StartMatch(IPlayer player);
        String ReadCenter(IPlayer player);
        String ReadFactories(IPlayer player);
        String ReadBoard(IPlayer player, IPlayer target);
        String Play(IPlayer player, String type, int factory, int tile, int model);
    }

    class PlayerService : IPlayerService
    {
        public String JoinMatch(IMatch match, String name, String password)
        {
            String response = Jogo.EntrarPartida(match.id, name, password);
            return response;
        }

        public string StartMatch(IPlayer player)
        {
            String response = Jogo.IniciarPartida(player.id, player.password);
            return response;
        }

        public string ReadCenter(IPlayer player)
        {
            
            String response = Jogo.LerCentro(player.id, player.password);
            return response;
        }

        public String ReadFactories(IPlayer player)
        {
            String response = Jogo.LerFabricas(player.id, player.password);
            return response;
        }

        public String ReadBoard(IPlayer player, IPlayer target)
        {
            String response = Jogo.LerTabuleiro(player.id, player.password, target.id);
            return response;
        }

        public String Play(IPlayer player, string type, int factory, int tile, int model)
        {
            return Jogo.Jogar(player.id, player.password, type, factory, tile, model);
        }
    }
}
