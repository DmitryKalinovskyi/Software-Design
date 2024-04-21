namespace Memento.Commands
{
    // part of code from lab01 https://github.com/DmitryKalinovskyi/Software-Design/blob/main/Lab01/ZooManager/ZooManager/Commands/Command.cs

    public abstract class Command : ICloneable
    {
        public string Description { get; set; }

        public Command()
        {
            Description = "";
        }

        public Command(string description)
        {
            Description = description;
        }

        public abstract void Execute(object? parameter);

        public abstract object Clone();
    }
}
