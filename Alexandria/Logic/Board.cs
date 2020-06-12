using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Alexandria.Logic.Bucket;
using Alexandria.Logic.Match;
using Alexandria.Logic.Model;
using Alexandria.Logic.Penalty;
using Alexandria.Logic.Pilot;
using Alexandria.Logic.Player;
using Alexandria.Logic.Position;
using Alexandria.Logic.Tile;
using Alexandria.Logic.Turn;

namespace Alexandria.Logic
{
    public interface IBoard
    {
        ITurn Turn { get; set; }
        Bucket.Bucket Center { get; set; }
        Dictionary<int, Bucket.Bucket> Factories { get; set; }
        Dictionary<int, IModel> Model { get; set; }
        List<IPosition> Wall { get; set; }
        List<IPenalty> Floor { get; set; }
        Boolean Finished { get; }


        void CheckTurn(IMatch match, IPlayer player);
        void ListPlayers(IMatch match);
        void StartGame(IPlayer player);
        void ReadCenter(IPlayer player);
        void ReadFactories(IPlayer player, IMatch match);
        void AutoPlay(IMatch match, IPlayer player);
        void ReadBoard(IMatch match, IPlayer player, IPlayer target);
    }

    class Board : IBoard
    {
        public ITurn Turn { get; set; }
        public Bucket.Bucket Center { get; set; }
        public Dictionary<int, Bucket.Bucket> Factories { get; set; }
        public Dictionary<int, IModel> Model { get; set; }
        public List<IPosition> Wall { get; set; }
        public List<IPenalty> Floor { get; set; }

        public Boolean Finished { get; private set; }

        private readonly ITurnService TurnService;
        private readonly ITurnFactory TurnFactory;
        private readonly IPlayerService PlayerService;
        private readonly IMultiLineFactory<IPlayer> PlayerMultiLineFactory;
        private readonly IMatchService MatchService;
        private readonly IBucketFactory BucketFactory;
        private readonly IModelFactory ModelFactory;
        private readonly IPositionFactory PositionFactory;
        private readonly IPenaltyFactory PenaltyFactory;
        private readonly IPilot Pilot;

        public Board(ITurnService turnService,
            ITurnFactory turnFactory,
            IPlayerService playerService,
            IMatchService matchService,
            IMultiLineFactory<IPlayer> playerMultiLineFactory,
            IBucketFactory bucketFactory,
            IModelFactory modelFactory,
            IPositionFactory positionFactory,
            IPenaltyFactory penaltyFactory,
            IPilot pilot)
        {
            this.Center = new Bucket.Bucket();
            this.Factories = new Dictionary<int, Bucket.Bucket>();
            this.Model = new Dictionary<int, IModel>();
            this.Floor = new List<IPenalty>();
            this.Wall = new List<IPosition>();
            this.Finished = false;

            this.TurnService = turnService;
            this.TurnFactory = turnFactory;
            this.MatchService = matchService;
            this.PlayerService = playerService;
            this.PlayerMultiLineFactory = playerMultiLineFactory;
            this.BucketFactory = bucketFactory;
            this.ModelFactory = modelFactory;
            this.PositionFactory = positionFactory;
            this.PenaltyFactory = penaltyFactory;
            this.Pilot = pilot;
        }

        public void CheckTurn(IMatch match, IPlayer player)
        {
            String response = TurnService.CheckTurn(player);

            if (response.StartsWith("E"))
            {
                this.Finished = true;
                return;
            }

            this.Turn = this.TurnFactory.Create(response, match.players);
        }

        public void ListPlayers(IMatch match)
        {
            String response = this.MatchService.ListPlayers(match);
            match.players = PlayerMultiLineFactory.Create(response);
        }

        public void StartGame(IPlayer player)
        {
            this.PlayerService.StartMatch(player);
        }

        public void ReadCenter(IPlayer player)
        {
            String response = this.PlayerService.ReadCenter(player);
            if (response.StartsWith("ERRO")) return;
            this.Center = this.BucketFactory.Create(response);
        }

        public void ReadFactories(IPlayer player, IMatch match)
        {
            String response = this.PlayerService.ReadFactories(player);
            if (response.StartsWith("ERRO")) return;
            this.Factories = this.BucketFactory.Create(response, (match.players.Count - 1) * 2 + 3);
        }

        public void AutoPlay(IMatch match, IPlayer player)
        {
            this.Pilot.Model = this.Model;
            this.Pilot.Wall = this.Wall;
            this.Pilot.Factories = this.Factories;
            this.Pilot.Center = this.Center;

            this.Pilot.Play();

            this.PlayerService.Play(player, this.Pilot.Type, this.Pilot.FactoryId, this.Pilot.TileId, this.Pilot.ModelId);
        }

        public void ReadBoard(IMatch match, IPlayer player, IPlayer target)
        {
            String response = this.PlayerService.ReadBoard(player, target);

            if (response.StartsWith("ERRO")) return;

            if (response != String.Empty)
            {
                String[] entities = response.Split(new[] { "modelo", "parede", "chão" }, StringSplitOptions.None);
                entities = entities.Where(x => !String.IsNullOrEmpty(x)).ToArray();

                this.Model = this.ModelFactory.Create(entities[0]);
                this.Wall = this.PositionFactory.Create(entities[1]);
                this.Floor = this.PenaltyFactory.Create(entities[2]);
            }
        }
    }
}
