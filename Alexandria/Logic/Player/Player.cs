using System;

namespace Alexandria.Logic.Player
{
    public interface IPlayer
    {
        int id { get; set; }
        String name { get; set; }
        String password { get; set; }
        int score { get; set; }
    }

    public class Player : IPlayer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int score { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
