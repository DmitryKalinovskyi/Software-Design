namespace Bridge.Shapes
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width = 1, int height = 1)
        {
            Width = width;
            Height = height;
        }

        public object GetRenderInfo()
        {
            return $"Rectangle with width = {Width} and height = {Height}";
        }
    }
}
