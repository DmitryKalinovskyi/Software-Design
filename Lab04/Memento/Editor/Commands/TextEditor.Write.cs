using Memento.Commands;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        public class WriteCommand : Command
        {
            private readonly TextEditorCaretaker _caretaker;
            public WriteCommand(TextEditorCaretaker caretaker)
            {
                _caretaker = caretaker;
                Description = "Writes buffer of characters to the document";
            }

            public override object Clone()
            {
                return new WriteCommand(_caretaker);
            }

            public override void Execute(object? parameter)
            {
                _caretaker.Save();

                Console.Write("Enter content: ");
                string buffer = Console.ReadLine();

                _caretaker.Originator._textDocument.Text.Append(buffer);
            }
        }
    }
}
