using ZooManagerLibrary.Entities;

namespace ZooManagerLibrary.Core
{
    /// <summary>
    /// Manages all entities related to Zoo
    /// </summary>
    public class ZooContext
    {
        public List<Animal> Animals { get; set; }

        public List<Aviary> Aviaries { get; set; }

        public List<Food> Foods { get; set; }

        public List<ZooWorker> ZooWorkers { get; set; }

        public List<AnimalType> AnimalTypes { get; set; }

        public ZooContext() 
        {
            Animals = new();
            Aviaries = new();
            Foods = new();
            ZooWorkers = new();
            AnimalTypes = new();
        }
    }
}
