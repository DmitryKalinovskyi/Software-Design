namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxyEBook : IEBook
    {
        public void Open()
        {
            Console.WriteLine("Opened balaxy ebook");
        }
    }
}
