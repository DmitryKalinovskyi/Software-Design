using ZooManager.Commands;
using ZooManager.Commands.CommandList;
using ZooManagerLibrary.Core;
using ZooManagerLibrary.Seeding;

// managing with data
ZooContext zooContext = new();
ZooContextSeeder.Seed(zooContext);

// building commands and running console command handler
CommandHandler commandHandler = new();

commandHandler.AddCommand("help", new ShowCommands(commandHandler));
commandHandler.AddAlias("help", "showCommands");

commandHandler.AddCommand("addAnimal", new AddAnimal(zooContext));

while (true)
{
    commandHandler.Execute(Console.ReadLine());
}