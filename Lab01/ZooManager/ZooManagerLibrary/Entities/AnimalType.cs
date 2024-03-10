using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Entities
{
    public class AnimalType: EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public AnimalType()
        {
            Name = "";
            Description = "";
        }

        public AnimalType(string name)
        {
            Name = name;
            Description = "";
        }

        public AnimalType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
