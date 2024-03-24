namespace Abstract_Factory.Products.Kiaomi
{
    public class KiaomiSmartphone : ISmartphone
    {
        public void Broke()
        {
            Console.WriteLine("I broked.");
        }

        public void TurnOn()
        {
            Broke();
        }
    }
}
