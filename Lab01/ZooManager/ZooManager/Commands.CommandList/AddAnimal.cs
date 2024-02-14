using ZooManagerLibrary.Core;

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

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override object Clone()
        {
            return new AddAnimal(_context, Description);
        }

        public override void Execute(object? parameter)
        {

        }
    }
}
