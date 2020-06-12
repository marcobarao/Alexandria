using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Alexandria.Logic.Model;
using Alexandria.Logic.Pilot;
using Alexandria.Logic.Position;

namespace Alexandria.Logic.Handler
{
    public class TileHandler : AbstractHandler
    {
        private readonly ModelHandler ModelHandler;
        private AbstractHandler _branchHandler;

        public TileHandler(ModelHandler modelHandler)
        {
            this.ModelHandler = modelHandler;
        }

        public override object Handle(object request)
        {
            IPilot pilot = (IPilot)request;

            if (pilot.Model.TryGetValue(pilot.ModelId, out var model) && model.quantity > 0)
            {
                Helper.ColorId.TryGetValue(model.color, out var id);

                pilot.TileId = id;
            }
            else
            {
                List<IPosition> activePositionsInModel = pilot.Wall.FindAll(tile => tile.Y == pilot.ModelId);
                int[] activeTilesInModel = activePositionsInModel.Select(position =>
                {
                    int result = ((5 - (position.Y - 1) + position.X) % 5);
                    return result == 0 ? 5 : result;
                }).ToArray();


                var differenceTilesInModel = pilot.Tiles.Except(activeTilesInModel);

                if (differenceTilesInModel.Count() > 0)
                {
                    pilot.TileId = differenceTilesInModel.ElementAt(0);
                }
                else
                {
                    pilot.Models = pilot.Models.Where(m => m != pilot.ModelId).ToArray();
                    this._branchHandler = this.ModelHandler;
                    this._branchHandler.SetNext(this);
                    this._branchHandler.Handle(pilot);
                }
            }


            return base.Handle(request);
        }
    }
}