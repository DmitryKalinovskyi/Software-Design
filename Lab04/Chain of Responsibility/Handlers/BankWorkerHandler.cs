using Chain_of_Responsibility.Menu;

namespace Chain_of_Responsibility.Handlers
{
    public class BankWorkerHandler : BaseHandler<DialogContext>
    {
        public override void Handle(DialogContext argument)
        {
            ConsoleMenu consoleMenu = new();

            consoleMenu
                .AddMenuOption("tell joke to john", () =>
                {
                    Console.WriteLine("Joke: Їде в потязі японець, німець та росіянин. Їдуть, стало нудно, ну японець дістав найновіший телефон, щось позалипав у нього годинку, і викинув у вікно. На нього німець і росіянин так дивляться:\r\n- Ти що робиш????\r\nА японець їм:\r\n- Пф, у мене в Японії цих телефонів навалом, завтра новий придбаю\r\n\r\nНу їдуть далі, тут німець дістав найкраще німецьке пиво, пив він його пив, до кінця не випив, половину вилив у вікно. Ну росіянин і японець його питають:\r\n- Нащо ти це зробив? Воно ж дуже дороге!\r\nА німець їм:\r\n\r\n- Та, у нас в Німеччині такого пива навалом\r\n\r\nНу росіянин довго не думав, і викинув у вікно:\r\nТанки — 5940\r\nББМ — 11015\r\nАртилерійські системи — 8391\r\nРСЗВ — 935\r\nЗасоби ППО — 617\r\nЛітаки — 329\r\nГелікоптери — 324\r\nБПЛА — 6503\r\nКрилаті ракети — 1620\r\nКораблі (катери) — 23\r\nПідводні човни — 1\r\nАвтомобілі та автоцистерни — 11180\r\nСпеціальна техніка — 1247\r\nОсобовий склад — близько 356670 осіб ");
                })

                .AddMenuOption("how to pay komunalka?", () =>
                {
                    Console.WriteLine("You don't need to pay komunalka.");
                })

                .AddMenuOption("change credit limit", () =>
                {
                    Console.WriteLine("Enter your passport code.");
                    string passportCode = Console.ReadLine();

                    Console.WriteLine("turn on camera please");

                    Console.WriteLine("Say limit you want to set.");
                    string limit = Console.ReadLine();

                    Console.WriteLine("Limit sucessfully seted.");
                })


                .AddMenuOption("i have other problem", () => HandleNext(argument));

            Console.WriteLine("John: how i can help you?");

            consoleMenu.HandleSelection();
        }
    }
}
