using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alexandria.Logic.Handler;
using Alexandria.Logic.Model;
using Alexandria.Logic.Player;
using Alexandria.Logic.Position;

namespace Alexandria.Logic.Pilot
{
    public interface IPilot
    {
        Bucket.Bucket Center { get; set; }
        Dictionary<int, Bucket.Bucket> Factories { get; set; }
        Dictionary<int, IModel> Model { get; set; }
        List<IPosition> Wall { get; set; }

        String Type { get; set; }
        int FactoryId { get; set; }

        int[] Tiles { get; set; }
        int TileId { get; set; }

        int[] Models { get; set; }
        int ModelId { get; set; }
        void Play();
    }

    public class Pilot : IPilot
    {
        public Bucket.Bucket Center { get; set; }
        public Dictionary<int, Bucket.Bucket> Factories { get; set; }
        public Dictionary<int, IModel> Model { get; set; }
        public List<IPosition> Wall { get; set; }
        public String Type { get; set; }
        public int FactoryId { get; set; }

        public int TileId { get; set; }
        public int[] Tiles { get; set; }

        public int ModelId { get; set; }
        public int[] Models { get; set; }

        private readonly AbstractHandler _initialHandler;

        public Pilot(ModelHandler modelHandler, TileHandler tileHandler, BucketHandler bucketHandler)
        {
            this._initialHandler = modelHandler;
            this._initialHandler.SetNext(tileHandler).SetNext(bucketHandler);
        }

        public void Play()
        {
            this.Models = new[] { 1, 2, 3, 4, 5 };
            this._initialHandler.Handle(this);
        }
    }
}
