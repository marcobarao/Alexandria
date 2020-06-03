using Alexandria.Logic;
using Alexandria.Logic.Bucket;
using Alexandria.Logic.Match;
using Alexandria.Logic.Model;
using Alexandria.Logic.Penalty;
using Alexandria.Logic.Pilot;
using Alexandria.Logic.Player;
using Alexandria.Logic.Position;
using Alexandria.Logic.Tile;
using Alexandria.Logic.Turn;
using Alexandria.Screens;
using Ninject.Modules;
using Ninject;

public class Bindings : NinjectModule
{
    public override void Load()
    {
        Bind<Alexandria.Screens.Lobby>().To<Alexandria.Screens.Lobby>();
        Bind<Alexandria.Screens.Board>().To<Alexandria.Screens.Board>();
        Bind<Alexandria.Screens.Result>().To<Alexandria.Screens.Result>();

        Bind<ILobby>().To<Alexandria.Logic.Lobby>();
        Bind<IBoard>().To<Alexandria.Logic.Board>();

        Bind<IPilot>().To<Pilot>();

        Bind<IModelFactory>().To<ModelFactory>();
        Bind<IPositionFactory>().To<PositionFactory>();
        Bind<IPenaltyFactory>().To<PenaltyFactory>();

        Bind<IMatch>().To<Match>();
        Bind<IMatchFactory>().To<MatchFactory>();
        Bind<IMatchService>().To<MatchService>();

        Bind<IPlayer>().To<Player>();
        Bind<IPlayerFactory>().To<PlayerFactory>();
        Bind<IPlayerService>().To<PlayerService>();

        Bind<Bucket>().To<Bucket>();
        Bind<IBucketFactory>().To<BucketFactory>();
        Bind<ITileGroup>().To<TileGroup>();
        Bind<ITileGroupFactory>().To<TileGroupFactory>();

        Bind<ITile>().To<Tile>();

        Bind<ITurn>().To<Turn>();
        Bind<ITurnService>().To<TurnService>();
        Bind<ITurnFactory>().To<TurnFactory>();

        Bind<IMultiLineFactory<IMatch>>().To<MultiLineFactory<IMatch>>();
        Bind<IFactory<IMatch>>().To<MatchFactory>();

        Bind<IMultiLineFactory<IPlayer>>().To<MultiLineFactory<IPlayer>>();
        Bind<IFactory<IPlayer>>().To<PlayerFactory>();
    }

    public static Bindings Create()
    {
        return new Bindings();
    }
}