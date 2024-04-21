using Chain_of_Responsibility.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Handlers
{
    public class AnsweringMachineHandler : BaseHandler<DialogContext>
    {
        public override void Handle(DialogContext argument)
        {
            ConsoleMenu consoleMenu = new();

            consoleMenu
                .AddMenuOption("i lost my card", () =>
                {
                    Console.WriteLine("Block card as fast as you can.");
                })

                .AddMenuOption("how to pay komunalka?", () =>
                {
                    Console.WriteLine("You don't need to pay komunalka.");
                })

                .AddMenuOption("i have other problem", () => HandleNext(argument));

            consoleMenu.HandleSelection();
        }
    }
}
