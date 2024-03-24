namespace Abstract_Factory.Products.IProne
{
    public class IProneEBook : IEBook
    {
        public void Open()
        {
            Console.WriteLine("IProne ebook running..");
            Console.WriteLine("Ok!..");
        }
    }
}
