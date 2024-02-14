using System.Windows.Input;

namespace ZooManager.Commands
{
    public abstract class Command: ICommand, ICloneable
    {
        public string Description { get; set; }

        public event EventHandler? CanExecuteChanged;

        public abstract bool CanExecute(object? parameter);

        public abstract void Execute(object? parameter);

        public abstract object Clone();

        public Command()
        {
            Description = "";
        }

        public Command(string description)
        {
            Description = description;
        }
    }
}
