# List of principlces used in Lab01

- Single Responsibility - all classes have only one purpose.
For example, each entity in class library represents one concrete entity,
ZooContext a context class of all ZooEntities.

- Open/Closed Principle - all classes are open for extending, but closed for changes.

- Interface Segregation Principle - in my solution each class do not contains
unnecessary methods for child classes.

- Composition over inheritance - instead of building class for different animals, 
we build class category, type that contains information about common
creatures. In my solution i used class AnimalType as element of Animal.
Sometimes composition can help programmer to avoid headache with one gigant
class, just separate it into several components.

- KISS - solution is well-structurized and class purpose correspondes 
to their actual names, this allow other user to upbuild the project because
it will be remained simple and modular. 

- YAGNI - this solution is also example of YAGNI usage,
because i implement things that needed to work for zoo, and nothing more.
Actual business logic and console interaction are separated into 2 projects.
If needed, GUI application with WPF or Win forms can be created.

- DRY - solution do not contains repeating code, classes are well-structurized with Command pattern usage, that helps to make code more dry.

- Program to Interfaces not Implementations - solution contains console project, that use Command pattern,
this is abstraction that allow to make different action using 
different class for each action.
	``` cs
	// building commands and running console command handler
	CommandHandler commandHandler = new();

	commandHandler.AddCommand("help", new ShowCommands(commandHandler));
	commandHandler.AddAlias("help", "showCommands");

	commandHandler.AddCommand("addAnimal", new AddAnimal(zooContext));
	commandHandler.AddCommand("report", new ShowSimpleReport(zooContext));
	commandHandler.AddCommand("reportFood", new ShowFoodReport(zooContext));
	```

	Each command inherits from Command class, which provide Execute method (interaction interface), which is used in command handling.


- Fail Fast - console project command handler will throw an error if you try assing command that already defined, this will prevent bugs and stop the application.

	``` cs
	public void AddCommand(string commandName, Command commandAction)
	{
		if(_commands.ContainsKey(commandName))
		{
			throw new InvalidOperationException($"Command with {commandName} name is created already.");
		}

		_commands[commandName] = commandAction;
	}
	```

