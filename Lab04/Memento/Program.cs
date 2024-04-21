using Memento.Commands;
using Memento.Editor;

var editor = new TextEditor();
var editorCaretaker = new TextEditorCaretaker(editor);


var commandHandler = new CommandHandler();

// you can use dependency injection to create commands
commandHandler.AddCommand("write", new TextEditor.WriteCommand(editorCaretaker));
commandHandler.AddAlias("write", "w");

commandHandler.AddCommand("display", new TextEditor.DisplayCommand(editor));
commandHandler.AddCommand("undo", new TextEditor.UndoCommand(editorCaretaker));

commandHandler.AddCommand("help", new TextEditor.HelpCommand(commandHandler));

commandHandler.AddCommandListener(["write", "w", "undo"], () =>
{
    Console.Clear();
    commandHandler.Execute("display");
});

commandHandler.Execute("display");

while (true)
{
    try
    {
        Console.Write("cmd: ");

        var command = Console.ReadLine();

        commandHandler.Execute(commandHandler.Tokenize(command));
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
}

// this is short example of memento usage.