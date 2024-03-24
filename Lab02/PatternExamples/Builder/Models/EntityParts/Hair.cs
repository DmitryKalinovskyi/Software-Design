using Builder.Models.Enchantments;
using Builder.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.EntityParts
{
    public class Hair
    {
        public Color Color { get; set; }    

        public IShape Shape { get; set; }

        // initialize with bold hair
        public Hair(): this(new Color(), new Shape()) { }

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
