using System;
using System.Collections.Generic;
using Alexandria.Logic.Player;

namespace Alexandria.Logic.Match
{
    public interface IMatch
    {
        int id { get; set; }
        String name { get; set; }
        String password { get; set; }
        DateTime date { get; set; }
        MatchStatus status { get; set; }
        List<IPlayer> players { get; set; }
    }

    public enum MatchStatus
    {
        T,
        A,
        J,
        E
    };

    public class Match : IMatch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime date { get; set; }
        public MatchStatus status { get; set; }
        public List<IPlayer> players { get; set; }
    }
}
