using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Commands
{
    // part of code from lab01 https://github.com/DmitryKalinovskyi/Software-Design/blob/main/Lab01/ZooManager/ZooManager/Commands/CommandHandler.cs
    // extended with command listener
    public partial class CommandHandler
    {
        private readonly Dictionary<string, Command> _commands;

        public event EventHandler<CommandArgs>? OnCommandExecute;

        public CommandHandler()
        {
            _commands = [];
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
            if (commandTokens.Length == 0)
                throw new ArgumentException("Command not specified.");

            var commandArgs = new CommandArgs(commandTokens[0], commandTokens[1..]);
            if (_commands.ContainsKey(commandArgs.CommandName))
            {
                _commands[commandArgs.CommandName].Execute(commandArgs.Parameters);

                OnCommandExecute?.Invoke(this, commandArgs);
            }
            else
            {
                throw new ArgumentException("Command not founded.");
            }
        }

        public void AddCommand(string commandName, Command commandAction)
        {
            if (_commands.ContainsKey(commandName))
            {
                throw new InvalidOperationException($"Command with {commandName} name is created already.");
            }

            _commands[commandName] = commandAction;
        }

        public void AddAlias(string commandName, string alias)
        {
            if (_commands.ContainsKey(commandName) == false)
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
            foreach (var pair in _commands)
            {
                builder.Append(pair.Key).Append(" - ").AppendLine(pair.Value.Description);
            }

            return builder.ToString();
        }
    }
}
