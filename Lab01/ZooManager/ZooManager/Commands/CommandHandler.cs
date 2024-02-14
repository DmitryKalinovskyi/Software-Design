using System.Text;

namespace ZooManager.Commands
{
    public class CommandHandler
    {
        private readonly Dictionary<string, Command> _commands;

        public CommandHandler() 
        {
            _commands = new();
        }

        public string[] Tokenize(string? command)
        {
            if (string.IsNullOrEmpty(command)) return Array.Empty<string>();

            return command.Trim().Split(' ');
        }

        public void Execute(string? command)
        {
            Execute(Tokenize(command));
        }

        public void Execute(string[] commandTokens)
        {
            var commandName = commandTokens[0];

            if(_commands.ContainsKey(commandName))
            {
                _commands[commandName].Execute(commandTokens[1..]);
            }
        }

        public void AddCommand(string commandName, Command commandAction)
        {
            if(_commands.ContainsKey(commandName))
            {
                throw new InvalidOperationException($"Command with {commandName} name is created already.");
            }

            _commands[commandName] = commandAction;
        }

        public void AddAlias(string commandName, string alias)
        {
            if(_commands.ContainsKey(commandName) == false)
            {
                throw new InvalidOperationException("You can't add alias to command that don't exist.");
            }

            if (_commands.ContainsKey(alias))
            {
                throw new InvalidOperationException($"Command with {alias} name is created already.");
            }

            var copyCommand = (Command)_commands[commandName].Clone();

            copyCommand.Description = $"alias to [{commandName}]";

            _commands[alias] = copyCommand;
        }

        public string GetCommandsInfo()
        {
            StringBuilder builder = new();
            builder.AppendLine("List of commands: ");
            foreach(var pair in _commands)
            {
                builder.Append(pair.Key).Append(" - ").AppendLine(pair.Value.Description);
            }

            return builder.ToString();
        }
    }
}
