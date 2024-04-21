namespace Memento.Commands
{
    public class CommandArgs
    {
        public string CommandName { get; set; }

        public string[] Parameters { get; set; }

        public CommandArgs(string commandName, string[] parameters)
        {
            CommandName = commandName; ;
            Parameters = parameters;
        }
    }
}
