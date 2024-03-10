using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Entities
{
    /// <summary>
    /// Describes aviary and animals inside it
    /// </summary>
    public class Aviary: EntityBase
    {
        public string ShortName { get; set; }

        public double Width { get; set; }
        
        public double Length { get; set; }

        public List<Animal> Animals { get; set; }

        public Aviary()
        {
            ShortName = "";
            Width = 0;
            Length = 0;
            Animals = new();
        }

        public Aviary(string shortName, double width, double length, List<Animal> animals)
        {
            ShortName = shortName;
            Width = width;
            Length = length;
            Animals = animals;
        }
    }
}
