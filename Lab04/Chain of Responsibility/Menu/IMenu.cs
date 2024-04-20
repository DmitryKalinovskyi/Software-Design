using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Menu
{
    public interface IMenu
    {
        public IMenu AddMenuOption(string optionName, Action onSelect);

        public IMenu RemoveMenuOption(string optionName);

        public string[] GetMenuOptions();

        public void Select(string optionName);
    }
}
