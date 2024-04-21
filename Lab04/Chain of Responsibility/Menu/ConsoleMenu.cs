using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Menu
{
    public class ConsoleMenu : IMenu
    {
        private readonly Dictionary<string, Action> _optionBindings = [];

        public string[] GetMenuOptions()
        {
            return [.. _optionBindings.Keys];
        }

        public IMenu RemoveMenuOption(string optionName)
        {
            _optionBindings.Remove(optionName);
            return this;
        }

        public void Select(string optionName)
        {
            if(_optionBindings.ContainsKey(optionName) == false) 
            {
                throw new InvalidOperationException("You can't choose option that don't present.");
            }

            _optionBindings[optionName]();
        }

        public IMenu AddMenuOption(string optionName, Action onSelect)
        {
            if (_optionBindings.ContainsKey(optionName))
            {
                throw new InvalidOperationException("This option already defined. Please remove it before and then add again.");
            }

            _optionBindings[optionName] = onSelect;
            return this;
        }

        public void RenderOptions()
        {
            int i = 1;
            foreach(var option in _optionBindings.Keys)
            {
                Console.WriteLine($"{i}: {option}");
                i++;
            }
        }

        private Dictionary<int, string> CreateNumberBindings()
        {
            var bindings = new Dictionary<int, string>();
            int i = 1;
            foreach(var option in _optionBindings.Keys)
            {
                bindings[i++] = option;
            }
            return bindings;
        }

        public void HandleSelection()
        {
            RenderOptions();
            var numberBindings = CreateNumberBindings();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter option: ");
                    var option = Console.ReadLine() ?? "";

                    // convert to number
                    if(int.TryParse(option, out int choice))
                    {
                        Select(numberBindings[choice]);
                    }
                    else
                    {
                        Select(option);
                    }

                    return;
                }
                catch
                {
                }
            }
        }
    }
}
