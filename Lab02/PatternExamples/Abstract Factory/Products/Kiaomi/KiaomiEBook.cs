namespace Abstract_Factory.Products.Kiaomi
{
    public class KiaomiEBook : IEBook
    {
        public void Open()
        {
            Console.WriteLine("Open miner");
            Console.WriteLine("Mine some crypto");
            Console.WriteLine("Close miner");

            Console.WriteLine("Run the application.");
        }
    }
}
