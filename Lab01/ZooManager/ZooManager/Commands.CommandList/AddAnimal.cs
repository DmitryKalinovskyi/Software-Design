using ZooManagerLibrary.Core;
using ZooManagerLibrary.Entities;

namespace ZooManager.Commands.CommandList
{
    public class AddAnimal : Command
    {
        private readonly ZooContext _context;

        public AddAnimal(ZooContext context)
        {
            _context = context;
        }

        public AddAnimal(ZooContext context, string description): base(description)
        {
            _context = context;
        }

        public override object Clone()
        {
            return new AddAnimal(_context, Description);
        }

        public override void Execute(object? parameter)
        {
            // Read animal data from console

            Animal animal = new();

            Console.Write("Enter animal name: ");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Enter birth date of animal in format dd-mm-yyyy: ");
            animal.BirthDate = DateTime.Parse(Console.ReadLine());

            _context.Animals.Add(animal);
        }
    }
}
