using ZooManagerLibrary.Core;
using ZooManagerLibrary.Entities;

namespace ZooManager.Commands.CommandList
{
    public class AddFood : Command
    {
        private ZooContext _context;
        
        public AddFood(ZooContext context)
        {
            _context = context;
            Description = "Begin operation to add new food to the storage.";
        }

        public AddFood(ZooContext context, string description)
        {
            _context = context;
            Description = description;
        }

        public override object Clone()
        {
            return new AddFood(_context, Description);
        }

        public override void Execute(object? parameter)
        {
            Console.WriteLine("Enter food name: ");
            string name = Console.ReadLine() ?? "unnamed";

            Console.WriteLine("Enter description of food: ");
            string description = Console.ReadLine() ?? "";


            int amount;
            while (true)
            {
                Console.WriteLine("Enter food amount: ");
                
                string rawAmount = Console.ReadLine();

                if(int.TryParse(rawAmount, out amount))
                {
                    break;
                }
            }

            _context.Foods.Add(new Food(name, description, amount));
        }
    }
}
