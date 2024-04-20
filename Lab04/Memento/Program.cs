﻿using Memento.Commands;
using Memento.Editor;

var editor = new TextEditor();
var editorCaretaker = new TextEditorCaretaker(editor);


var commandHandler = new CommandHandler();

// you can use dependency injection to create commands
commandHandler.AddCommand("write", new TextEditor.WriteCommand(editorCaretaker));
commandHandler.AddAlias("write", "w");

commandHandler.AddCommand("display", new TextEditor.DisplayCommand(editor));

while (true)
{
    try
    {

        // display document
        commandHandler.Execute("display");

        Console.Write("cmd: ");
        var command = Console.ReadLine();

        commandHandler.Execute(commandHandler.Tokenize(command));
        Console.Clear();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
}