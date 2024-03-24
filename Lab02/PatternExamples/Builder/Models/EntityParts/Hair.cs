using Builder.Shapes;
using System.Drawing;

namespace Builder.Models.EntityParts
{
    public class Hair
    {
        public Color Color { get; set; }

        public IShape Shape { get; set; }

        // initialize with bold hair
        public Hair() : this(new Color(), new Shape()) { }

        public Hair(Color hairColor, IShape shape)
        {
            Color = hairColor;
            Shape = shape;
        }

        public string GetInfo()
        {
            return $"Hair color {Color}, shape - {Shape.Name}";
        }
    }
}
