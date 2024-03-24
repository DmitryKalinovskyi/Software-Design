using Abstract_Factory.Products;
using Abstract_Factory.Products.Balaxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
