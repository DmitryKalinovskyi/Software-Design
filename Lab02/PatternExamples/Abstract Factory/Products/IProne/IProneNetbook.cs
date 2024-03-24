namespace Abstract_Factory.Products.IProne
{
    public class IProneNetbook : INetbook
    {
        public void OpenNetwork()
        {
            Console.WriteLine("Network configured with speed 100mbit/s.");
        }
    }
}
