namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxySmartphone : ISmartphone
    {
        private void ShowBalaxyLogo()
        {
            Console.WriteLine("Balaxy logo.");
        }

        public void TurnOn()
        {
            ShowBalaxyLogo();
        }
    }
}
