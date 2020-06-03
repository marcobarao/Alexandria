using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandria.Logic.Player;

namespace Alexandria.Logic.Bucket
{
    interface IBucketFactory : IFactory<Bucket>
    {
        Dictionary<int, Bucket> Create(string response, int quantity);
    }

    public class BucketFactory : IBucketFactory
    {
        private readonly ITileGroupFactory TileGroupFactory;

        public BucketFactory(ITileGroupFactory tileGroupFactory)
        {
            this.TileGroupFactory = tileGroupFactory;
        }

        public Bucket Create(string response)
        {
            if (response == String.Empty) return new Bucket();

            String responseTrim = response.Trim();
            responseTrim = responseTrim.Replace("\n", String.Empty);
            String[] entities = responseTrim.Split('\r');

            Bucket bucket = new Bucket();

            foreach (String entity in entities)
            {
                ITileGroup group = this.TileGroupFactory.Create(entity);
                bucket.Add(group.Tile.id, group);
            }

            return bucket;
        }

        public Dictionary<int, Bucket> Create(string response, int quantity)
        {
            if (response == String.Empty) return new Dictionary<int, Bucket>();

            String responseTrim = response.Trim();
            responseTrim = responseTrim.Replace("\n", String.Empty);
            String[] entities = responseTrim.Split('\r');

            Dictionary<int, Bucket> buckets = new Dictionary<int, Bucket>();

            for (int i = 1; i <= quantity; i++)
            {
                buckets.Add(i, new Bucket());
            }

            foreach (string entity in entities)
            {
                string[] actualValue = entity.Split(new char[] { ',' }, 2);
                int bucketId = Convert.ToInt32(actualValue[0]);

                ITileGroup group = this.TileGroupFactory.Create(actualValue[1]);
                if (buckets.TryGetValue(bucketId, out var bucket))
                {
                    bucket.Add(group.Tile.id, group);
                }
            }


            return buckets;
        }
    }
}
