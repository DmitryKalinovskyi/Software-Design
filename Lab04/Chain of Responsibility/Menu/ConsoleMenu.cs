using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Menu
{
    public class ConsoleMenu : IMenu
    {
        private Dictionary<string, Action> _optionBindings;

        public ConsoleMenu()
        {
            _optionBindings = new Dictionary<string, Action>();
        }

        public string[] GetMenuOptions()
        {
            return _optionBindings.Keys.ToArray();
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

        public void HandleSelection()
        {
            RenderOptions();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter option: ");
                    var option = Console.ReadLine() ?? "";
                    Select(option);
                    break;
                }
                catch
                {
                }
            }
        }
    }
}
