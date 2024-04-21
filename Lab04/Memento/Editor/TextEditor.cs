using Memento.Editor.Memento.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        private TextDocument _textDocument;

        // for poc versiion this is enought.

        public TextEditor()
        {
            _textDocument = new TextDocument(); 
        }
    }
}
