namespace Prototype
{
    public class Border
    {
        public Border(int thickness, string color)
        {
            Thickness = thickness;
            Color = color;
        }

        public int Thickness { get; set; }
        public string Color { get; set; }
    }
}