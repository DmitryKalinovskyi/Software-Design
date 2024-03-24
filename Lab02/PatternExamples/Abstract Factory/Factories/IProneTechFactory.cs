using Abstract_Factory.Products;
using Abstract_Factory.Products.IProne;

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
