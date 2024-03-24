namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxyNetbook : INetbook
    {
        public void OpenNetwork()
        {
            Console.WriteLine("Looking for the netowork port.");
            Console.WriteLine("Connected to network successfully.");
        }
    }
}
