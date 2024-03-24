using Builder.Models.Enchantments;
using Builder.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
