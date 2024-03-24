using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    public interface ITechFactory
    {
        public IEBook CreateEBook();

        public ILaptop CreateLaptop();

        public INetbook CreateNetbook();

        public ISmartphone CreateSmartphone();
    }
}
