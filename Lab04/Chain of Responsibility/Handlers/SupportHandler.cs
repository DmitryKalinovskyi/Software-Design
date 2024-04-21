using Chain_of_Responsibility.Menu;

namespace Chain_of_Responsibility.Handlers
{
    public class SupportHandler : BaseHandler<DialogContext>
    {
        public override void Handle(DialogContext argument)
        {
            ConsoleMenu consoleMenu = new();

            consoleMenu
                .AddMenuOption("i can't open deposit", () =>
                {
                    Console.WriteLine("To open deposit follow this instructions..");
                })

                .AddMenuOption("Someone has stole my card", () =>
                {
                    Console.WriteLine("You need to close your card as fast as you can.");
                })

                .AddMenuOption("I want to report a bug", () =>
                {
                    Console.WriteLine("Our app don't have any bug.");
                })

                .AddMenuOption("make a call", () => HandleNext(argument));

            consoleMenu.HandleSelection();
        }
    }
}
