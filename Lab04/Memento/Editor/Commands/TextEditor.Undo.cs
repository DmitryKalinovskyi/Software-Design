using Memento.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        public class UndoCommand : Command
        {
            private readonly TextEditorCaretaker _caretaker;

            public UndoCommand(TextEditorCaretaker caretaker)
            {
                _caretaker = caretaker;
                Description = "Returns editor to it's previous state.";
            }

            public override object Clone()
            {
                return new UndoCommand(_caretaker);
            }

            public override void Execute(object? parameter)
            {
                _caretaker.Undo();
            }
        }
    }
}
