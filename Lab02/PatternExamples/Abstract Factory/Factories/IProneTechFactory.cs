using Abstract_Factory.Products;
using Abstract_Factory.Products.IProne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public class IProneTechFactory : ITechFactory
    {
        public IEBook CreateEBook()
        {
            return new IProneEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }
}
