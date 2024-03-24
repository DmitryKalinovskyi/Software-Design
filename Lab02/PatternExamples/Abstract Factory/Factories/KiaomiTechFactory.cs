using Abstract_Factory.Products;
using Abstract_Factory.Products.Kiaomi;

namespace Abstract_Factory.Factories
{
    public class KiaomiTechFactory : ITechFactory
    {
        public IEBook CreateEBook()
        {
            return new KiaomiEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new KiaomiNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
}
