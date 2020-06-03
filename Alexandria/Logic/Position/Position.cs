namespace Alexandria.Logic.Position
{
    public interface IPosition
    {
        int X { get; set; }
        int Y { get; set; }
    }

    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
