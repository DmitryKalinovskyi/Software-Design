﻿using Builder.Models.Enchantments;
using Builder.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.EntityParts
{
    public class Hat : IClothPart
    {
        public string Name { get; set; }
        public IShape Shape { get; set; }
        public IEhchantment? Ehchanment { get; set; }

        public Hat() : this("?", new Shape()) { }

        public Hat(string name, IShape shape) : this(name, shape, null) { }

        public Hat(string name, IShape shape, IEhchantment? ehchanment)
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
