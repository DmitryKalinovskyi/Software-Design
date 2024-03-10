using System.Globalization;
using System.Text;
using ZooManager.Commands;
using ZooManager.Commands.CommandList;
using ZooManagerLibrary.Core;
using ZooManager.Seeding;

// managing with data
ZooContext zooContext = new();
ZooContextSeeder.Seed(zooContext);

// building commands and running console command handler
CommandHandler commandHandler = new();

commandHandler.AddCommand("help", new ShowCommands(commandHandler));
commandHandler.AddAlias("help", "showCommands");

commandHandler.AddCommand("addAnimal", new AddAnimal(zooContext));
commandHandler.AddCommand("report", new ShowSimpleReport(zooContext));
commandHandler.AddCommand("reportFood", new ShowFoodReport(zooContext));

// set up encoding and deciamal rule
Console.OutputEncoding = Encoding.UTF8;

var culture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
culture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = culture;

while (true)
{
    commandHandler.Execute(Console.ReadLine());
}