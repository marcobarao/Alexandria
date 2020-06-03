using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandria.Logic.Bucket;

namespace Alexandria.Logic.Model
{
    public interface IModelFactory
    {
        Dictionary<int, IModel> Create(String response);
    }

    public class ModelFactory : IModelFactory
    {
        public Dictionary<int, IModel> Create(String response)
        {
            String responseTrim = response.Trim();
            responseTrim = responseTrim.Replace("\n", String.Empty);

            if (responseTrim == String.Empty) return new Dictionary<int, IModel>();

            String[] entities = responseTrim.Split('\r');

            Dictionary<int, IModel> models = new Dictionary<int, IModel>();

            foreach (String entity in entities)
            {
                String[] modelData = entity.Split(',');

                IModel model = new Model();

                int id = Convert.ToInt32(modelData[1]);
                Helper.Colors.TryGetValue(id, out var color);
                model.color = color;
                model.line = Convert.ToInt32(modelData[0]);
                model.quantity = Convert.ToInt32(modelData[2]);

                models.Add(model.line, model);
            }

            return models;
        }
    }
}
