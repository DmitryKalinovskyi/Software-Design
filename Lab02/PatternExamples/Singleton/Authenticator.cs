namespace Singleton
{
    public class Authenticator
    {
        private static Authenticator? mainAuthenticator;

        private static readonly object _lock = new();

        public static Authenticator MainAuthenticator
        {
            get
            {
                if (mainAuthenticator == null)
                {
                    // lock to prevent overriding main instance.
                    lock (_lock)
                    {
                        mainAuthenticator ??= new Authenticator();
                    }
                }

                return mainAuthenticator;
            }
        }

        private Authenticator()
        {
            Stamp = Guid.NewGuid();
            Console.WriteLine(Stamp);
        }

        private Guid Stamp { get; set; }

        public void Authenticate()
        {
            Console.WriteLine($"{Stamp}: Authentication ...");
        }
    }
}
