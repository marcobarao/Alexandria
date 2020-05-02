using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Logic
{
    public interface IMultiLineFactory<O>
    {
        List<O> Create(String response);
    }

    class MultiLineFactory<O> : IMultiLineFactory<O>
    {
        private readonly IFactory<O> Factory;

        public MultiLineFactory(IFactory<O> factory)
        {
            this.Factory = factory;
        }

        public List<O> Create(String multiLine)
        {
            if (multiLine == String.Empty) return new List<O>();

            String multiLneTrim = multiLine.Trim();
            multiLneTrim = multiLneTrim.Replace("\n", String.Empty);
            String[] entities = multiLneTrim.Split('\r');

            List<O> entitiesList = new List<O>();

            foreach (String entity in entities)
            {
                entitiesList.Add(Factory.Create(entity));
            }

            return entitiesList;
        }
    }
}
