using Chain_of_Responsibility.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Handlers
{
    public class ApplicationHandler : BaseHandler<DialogContext>
    {
        public override void Handle(DialogContext argument)
        {
            ConsoleMenu consoleMenu = new();

            consoleMenu
                .AddMenuOption("make transaction", () =>
                {
                    Console.WriteLine("Enter sum: ");
                    var sum = Console.ReadLine();

                    Console.WriteLine("Enter card-id:");
                    var cardId = Console.ReadLine();

                    MakeTransaction(sum, cardId);
                })

                .AddMenuOption("check balance", () =>
                {
                    Console.WriteLine("You have very big balance!");
                })

                .AddMenuOption("support", () => HandleNext(argument));

            consoleMenu.HandleSelection();
        }

        private void MakeTransaction(string? sum, string? cardId)
        {
            Console.WriteLine($"You send {sum} to the card {cardId}!");
        }
    }
}
