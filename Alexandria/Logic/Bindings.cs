using Alexandria.Logic;
using Alexandria.Logic.Match;
using Alexandria.Logic.Player;
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

        Bind<ILobby>().To<Alexandria.Logic.Lobby>();
        Bind<IBoard>().To<Alexandria.Logic.Board>();

        Bind<IMatch>().To<Match>();
        Bind<IMatchFactory>().To<MatchFactory>();
        Bind<IMatchService>().To<MatchService>();

        Bind<IPlayer>().To<Player>();
        Bind<IPlayerFactory>().To<PlayerFactory>();
        Bind<IPlayerService>().To<PlayerService>();

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