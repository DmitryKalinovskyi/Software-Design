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
        public class DisplayCommand(TextEditor _originator) : Command
        {
            public override object Clone()
            {
                return new DisplayCommand(_originator);
            }

            public override void Execute(object? parameter)
            {
                Console.WriteLine(_originator._textDocument.ToString());
            }
        }
    }
}
