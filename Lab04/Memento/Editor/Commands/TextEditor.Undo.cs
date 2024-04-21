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
        public class UndoCommand(TextEditorCaretaker caretaker) : Command
        {
            public override object Clone()
            {
                return new UndoCommand(caretaker);
            }

            public override void Execute(object? parameter)
            {
                caretaker.Undo();
            }
        }
    }
}
