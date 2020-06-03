using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Alexandria.Logic.Pilot;

namespace Alexandria.Logic.Handler
{
    public class BucketHandler : AbstractHandler
    {
        private readonly ModelHandler ModelHandler;
        private readonly TileHandler TileHandler;
        private AbstractHandler _branchHandler;

        public BucketHandler(ModelHandler modelHandler, TileHandler tileHandler)
        {
            this.ModelHandler = modelHandler;
            this.TileHandler = tileHandler;
        }

        public override object Handle(object request)
        {
            KeyValuePair<int, Bucket.Bucket> bucket;
            IPilot pilot = (IPilot)request;

            pilot.Type = "F";
            bucket = pilot.Factories.FirstOrDefault(kv => kv.Value.ContainsKey(pilot.TileId));

            pilot.FactoryId = bucket.Key;

            if (pilot.FactoryId == 0)
            {
                pilot.Center.TryGetValue(pilot.TileId, out var center);

                if (center.Quantity > 0)
                {

                    pilot.Type = "C";
                }
                else
                {
                    if (pilot.Model.TryGetValue(pilot.ModelId, out var model) && model.quantity > 0)
                    {
                        pilot.Models = pilot.Models.Where(m => m != pilot.ModelId).ToArray();
                        this._branchHandler = ModelHandler;
                        this._branchHandler.SetNext(TileHandler).SetNext(this);
                        this._branchHandler.Handle(pilot);
                    }
                    else
                    {
                        pilot.Tiles = pilot.Tiles.Where(tile => tile != pilot.TileId).ToArray();
                        this._branchHandler = TileHandler;
                        this._branchHandler.SetNext(this);
                        this._branchHandler.Handle(pilot);
                    }
                        
                }
            }

            return base.Handle(request);
        }
    }
}