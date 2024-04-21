using Memento.Commands;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        public class HelpCommand : Command
        {
            private readonly CommandHandler _commandHandler;

            public HelpCommand(CommandHandler commandHandler)
            {
                Description = "Show list of supported commands.";
                _commandHandler = commandHandler;
            }

            public override object Clone()
            {
                return new HelpCommand(_commandHandler);
            }

            public override void Execute(object? parameter)
            {
                Console.WriteLine("Supported commands.");
                Console.WriteLine(_commandHandler.GetCommandsInfo());
            }
        }
    }
}
