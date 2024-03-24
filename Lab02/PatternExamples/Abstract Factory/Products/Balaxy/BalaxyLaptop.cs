namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxyLaptop : ILaptop
    {
        public void StartOs()
        {
            Console.WriteLine("Looking at configuration file.");
            Console.WriteLine("Configuration file loaded.");

            Console.WriteLine("Starting OS.");
            Console.WriteLine("25%.");
            Console.WriteLine("66%.");
            Console.WriteLine("100%.");
            Console.WriteLine("Hello at shindows 10!");
        }
    }
}
