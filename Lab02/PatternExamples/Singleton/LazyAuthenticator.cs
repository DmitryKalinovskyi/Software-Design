namespace Singleton
{
    /// <summary>
    /// Without locks, also thread safe.
    /// </summary>
    public class LazyAuthenticator
    {
        private static Lazy<LazyAuthenticator> mainAuthenticator = new(() => new LazyAuthenticator(),
            LazyThreadSafetyMode.ExecutionAndPublication);

        public static LazyAuthenticator MainAuthenticator
        {
            get
            {
                return mainAuthenticator.Value;
            }
        }

        private LazyAuthenticator()
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
