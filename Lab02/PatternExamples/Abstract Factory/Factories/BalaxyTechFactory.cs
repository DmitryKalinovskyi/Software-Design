﻿using Abstract_Factory.Products;
using Abstract_Factory.Products.Balaxy;

namespace Abstract_Factory.Factories
{
    public class BalaxyTechFactory : ITechFactory
    {
        public IEBook CreateEBook()
        {
            return new BalaxyEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new BalaxyNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
    }
}
