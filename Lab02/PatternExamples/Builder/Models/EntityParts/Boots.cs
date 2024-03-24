using Builder.Models.Enchantments;
using Builder.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.EntityParts
{
    public class Boots : IClothPart
    {
        public string Name { get; set; }
        public IShape Shape { get; set; }
        public IEhchantment? Ehchanment { get; set; }

        public Boots(): this("?", new Shape(), null) { }

        public Boots(string name, IShape bootsShape, IEhchantment? ehchanment)
        {
            Name = name;
            Shape = bootsShape;
            Ehchanment = ehchanment;
        }

        public string GetInfo()
        {
            return Name;
        }
    }
}
