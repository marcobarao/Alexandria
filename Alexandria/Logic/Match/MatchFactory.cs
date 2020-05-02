using System;
using System.Globalization;

namespace Alexandria.Logic.Match
{
    public interface IMatchFactory : IFactory<IMatch>
    {
        IMatch Create(String name, String password);
    }

    class MatchFactory : IMatchFactory
    {
        public IMatch Create(string response)
        {
            Match match = new Match();
            String[] data = response.Split(',');

            match.id = Convert.ToInt32(data[0]);
            match.name = data[1];
            match.date = DateTime.ParseExact(data[2], "dd/MM/yyyy",
                CultureInfo.CreateSpecificCulture("pt-BR"));

            MatchStatus status;
            if (MatchStatus.TryParse(data[3], true, out status))
            {
                match.status = status;
            }
            else
            {
                match.status = MatchStatus.A;
            }
            

            return match;
        }

        public IMatch Create(string name, string password)
        {
            Match match = new Match();

            match.name = name;
            match.password = password;
            match.date = DateTime.Now;
            match.status = MatchStatus.A;

            return match;
        }
    }
}
