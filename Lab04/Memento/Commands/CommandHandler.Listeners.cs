using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Commands
{
    public partial class CommandHandler
    {
        private readonly Dictionary<string, List<Action>> _commandListeners = [];

        public void AddCommandListener(string command, Action listener)
        {
            if (_commands.ContainsKey(command) == false)
                throw new ArgumentException("You can't add event listener to the command, that not present.");

            OnCommandExecute += (sender, args) =>
            {
                if(command == args.CommandName)
                listener();
            };
        }

        public void AddCommandListener(string[] commands, Action listener)
        {
            foreach (string command in commands)
            {
                AddCommandListener(command, listener);
            }
        }
    }
}
