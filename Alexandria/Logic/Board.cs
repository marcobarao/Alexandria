using System;
using Alexandria.Logic.Match;
using Alexandria.Logic.Player;
using Alexandria.Logic.Turn;

namespace Alexandria.Logic
{
    public interface IBoard
    {
        ITurn Turn { get; set; }

        void CheckTurn(IMatch match, IPlayer player);
    }

    class Board : IBoard
    {
        public ITurn Turn { get; set; }
        private readonly ITurnService TurnService;
        private readonly ITurnFactory TurnFactory;

        public Board(ITurnService turnService, ITurnFactory turnFactory)
        {
            this.TurnService = turnService;
            this.TurnFactory = turnFactory;
        }

        public void CheckTurn(IMatch match, IPlayer player)
        {
            String response = TurnService.CheckTurn(player);
            this.Turn = this.TurnFactory.Create(response, match.players);
        }
    }
}
