using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Entities
{
    public class Animal: EntityBase
    {
        public string Name { get; set; }    

        public DateTime BirthDate { get; set; }

        // composition over inheritance 
        public AnimalType? Type { get; set; }

        public Animal()
        {
            Name = "";
            BirthDate = DateTime.MinValue;
            Type = null;
        }

        public Animal(string name, DateTime birthDate, AnimalType? type)
        {
            Name = name;
            BirthDate = birthDate;
            Type = type;
        }
    }
}
