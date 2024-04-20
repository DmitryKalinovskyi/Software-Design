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
        public class WriteCommand(TextEditorCaretaker caretaker) : Command
        {
            public override object Clone()
            {
                return new WriteCommand(caretaker);
            }

            public override void Execute(object? parameter)
            {
                caretaker.Save();

                string[] str = parameter as string[] ?? [""];
                
                caretaker.Originator._textDocument.Text.Append(string.Join("", str));
            }
        }
    }
}
