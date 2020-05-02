using System;

namespace Alexandria.Logic.Player
{
    public interface IPlayerFactory : IFactory<IPlayer>
    {
        IPlayer Create(String name, String response);
    }

    class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(String response)
        {
            Player player = new Player();
            String[] data = response.Split(',');

            player.id = Convert.ToInt32(data[0]);
            player.name = data[1];
            player.score = Convert.ToInt32(data[2]);

            return player;
        }

        public IPlayer Create(String name, String response)
        {
            Player player = new Player();
            String[] data = response.Split(',');

            player.id = Convert.ToInt32(data[0]);
            player.name = name;
            player.password = data[1];

            return player;
        }
    }
}
