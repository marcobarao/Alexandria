using System;
using System.Collections.Generic;

namespace Alexandria.Logic.Position
{
    public interface IPositionFactory
    {
        List<IPosition> Create(String response);
    }

    public class PositionFactory : IPositionFactory
    {
        public List<IPosition> Create(string response)
        {
            String responseTrim = response.Trim();
            responseTrim = responseTrim.Replace("\n", String.Empty);
            if (responseTrim == String.Empty) return new List<IPosition>();

            String[] entities = responseTrim.Split('\r');

            List<IPosition> positions = new List<IPosition>();

            foreach (String entity in entities)
            {
                String[] positionData = entity.Split(',');
                IPosition position = new Logic.Position.Position();

                position.Y = Convert.ToInt32(positionData[0]);
                position.X = Convert.ToInt32(positionData[1]);

                positions.Add(position);
            }

            return positions;
        }
    }
}
