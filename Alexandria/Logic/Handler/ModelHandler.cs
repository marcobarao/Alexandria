using System;
using System.Linq;
using System.Windows.Forms;
using Alexandria.Logic.Pilot;

namespace Alexandria.Logic.Handler
{
    public class ModelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            IPilot pilot = (IPilot)request;

            int[] fullModels = pilot.Model.Values.Where(line => line.quantity == line.line).Select(line => line.line).ToArray();
            var possible = pilot.Models.Except(fullModels);

            if (possible.Count() > 0)
            {
                pilot.ModelId = possible.ElementAt(0);
            }
            else
            {
                pilot.ModelId = 0;
            }
            

            pilot.Tiles = Enumerable.Range(1, 5).Select(column =>
            {
                int result = ((5 - (pilot.ModelId - 1) + column) % 5);
                return result == 0 ? 5 : result;
            }).ToArray();

            return base.Handle(request);
        }
    }
}
