using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Entities
{
    public class Food: EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public Food() 
        {
            Name = "";
            Description = "";
            Amount = 0;
        }

        public Food(string name, string description, int amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Food: {Name}, amount: {Amount}";
        }
    }
}
