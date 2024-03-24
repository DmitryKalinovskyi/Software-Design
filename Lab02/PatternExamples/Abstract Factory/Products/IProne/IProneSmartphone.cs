namespace Abstract_Factory.Products.IProne
{
    public class IProneSmartphone : ISmartphone
    {
        private void PromptAvaibleUpdates()
        {
            Console.WriteLine("This is last version of device.");
        }

        private void DisplayDesktop()
        {
            Console.WriteLine("Call, Messages, X, Instagram");
        }

        public void TurnOn()
        {
            PromptAvaibleUpdates();
            
            DisplayDesktop();
        }
    }
}
