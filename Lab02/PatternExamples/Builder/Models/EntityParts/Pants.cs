using Builder.Models.Enchantments;
using Builder.Shapes;

namespace Builder.Models.EntityParts
{
    public class Pants : IClothPart
    {
        public string Name { get; set; }
        public IShape Shape { get; set; }
        public IEhchantment? Ehchanment { get; set; }

        public Pants() : this("?", new Shape()) { }

        public Pants(string name, IShape shape) : this(name, shape, null) { }

        public Pants(string name, IShape shape, IEhchantment? ehchanment)
        {
            Name = name;
            Shape = shape;
            Ehchanment = ehchanment;
        }

        public string GetInfo()
        {
            return Name;
        }
    }
}
