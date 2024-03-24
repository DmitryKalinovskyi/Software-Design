using Builder.Models.Enchantments;
using Builder.Shapes;

namespace Builder.Models.EntityParts
{
    public interface IClothPart
    {
        public string Name { get; set; }

        public IShape Shape { get; set; }

        public IEhchantment? Ehchanment { get; set; }

        public string GetInfo();
    }
}
