using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Entities
{
    /// <summary>
    /// Manages information about worker
    /// </summary>
    public class ZooWorker: EntityBase
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Job { get; set; }

        public ZooWorker()
        {
            Name = "";
            Surname = "";
            Job = "";
        }

        public ZooWorker(string name, string surname, string job)
        {
            Name = name;
            Surname = surname;
            Job = job;
        }
    }
}
