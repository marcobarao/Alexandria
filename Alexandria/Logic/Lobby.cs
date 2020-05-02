using System;
using System.Collections.Generic;
using Alexandria.Logic.Match;
using Alexandria.Logic.Player;

namespace Alexandria.Logic
{
    public interface ILobby
    {
        List<IMatch> Matches { get; set; }
        void ListOpenMatches();
        void CreateMatch(String name, String password);

        void ListPlayers(IMatch match);
        IPlayer JoinMatch(IMatch match, string name, string password);
    }

    public class Lobby : ILobby
    {
        private readonly IMatchService MatchService;
        private readonly IMatchFactory MatchFactory;
        private readonly IMultiLineFactory<IMatch> MatchMultiLineFactory;

        private readonly IPlayerService PlayerService;
        private readonly IPlayerFactory PlayerFactory;
        private readonly IMultiLineFactory<IPlayer> PlayerMultiLineFactory;

        public List<IMatch> Matches { get; set; }

        public Lobby(IMatchService matchService,
            IMatchFactory matchFactory,
            IMultiLineFactory<IMatch> matchMultiLineFactory,
            IPlayerService playerService,
            IPlayerFactory playerFactory,
            IMultiLineFactory<IPlayer> playerMultiLineFactory)
        {
            this.MatchService = matchService;
            this.MatchFactory = matchFactory;
            this.MatchMultiLineFactory = matchMultiLineFactory;

            this.PlayerService = playerService;
            this.PlayerFactory = playerFactory;
            this.PlayerMultiLineFactory = playerMultiLineFactory;
            this.Matches = new List<IMatch>();
        }

        public void ListOpenMatches()
        {
            String response = this.MatchService.FindByStatus(MatchStatus.A);

            this.Matches = this.MatchMultiLineFactory.Create(response);
        }

        public void CreateMatch(String name, String password)
        {
            IMatch match = MatchFactory.Create(name, password);
            String id = this.MatchService.CreateMatch(match);
            match.id = Convert.ToInt32(id);

            this.Matches.Add(match);
        }

        public void ListPlayers(IMatch match)
        {
            String response = this.MatchService.ListPlayers(match);

            match.players = PlayerMultiLineFactory.Create(response);
        }

        public IPlayer JoinMatch(IMatch match, string name, string password)
        {
            String response = this.PlayerService.JoinMatch(match, name, password);
            IPlayer player = PlayerFactory.Create(name, response);

            return player;
        }
    }
}
