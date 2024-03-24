using Builder.Models.Enchantments;
using Builder.Shapes;

namespace Builder.Models.EntityParts
{
    public class UpperBodyPart : IClothPart
    {
        public string Name { get; set; }
        public IShape Shape { get; set; }
        public IEhchantment? Ehchanment { get; set; }

        public UpperBodyPart() : this("?", new Shape()) { }

        public UpperBodyPart(string name, IShape shape) : this(name, shape, null) { }

        public UpperBodyPart(string name, IShape shape, IEhchantment? ehchanment)
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
