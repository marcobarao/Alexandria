using System.Drawing;

namespace Alexandria.Logic.Model
{
    public interface IModel
    {
        Color color { get; set; }
        int line { get; set; }
        int quantity { get; set; }
    }

    public class Model : IModel
    {
        public Color color { get; set; }
        public int line { get; set; }
        public int quantity { get; set; }
    }
}
