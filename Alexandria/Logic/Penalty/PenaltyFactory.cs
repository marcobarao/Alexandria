using System;
using System.Collections.Generic;

namespace Alexandria.Logic.Penalty
{
    public interface IPenaltyFactory
    {
        List<IPenalty> Create(String response);
    }

    public class PenaltyFactory : IPenaltyFactory
    {
        public List<IPenalty> Create(string response)
        {
            String responseTrim = response.Trim();
            responseTrim = responseTrim.Replace("\n", String.Empty);
            if (responseTrim == String.Empty) return new List<IPenalty>();

            String[] entities = responseTrim.Split('\r');

            List<IPenalty> penalties = new List<IPenalty>();

            foreach (String entity in entities)
            {
                String[] penaltyData = entity.Split(',');
                IPenalty penalty = new Penalty();

                int id = Convert.ToInt32(penaltyData[1]);
                Helper.Colors.TryGetValue(id, out var color);
                penalty.color = color;
                penalty.penalty = Convert.ToInt32(penaltyData[2]);

                penalties.Add(penalty);
            }

            return penalties;
        }
    }
}
