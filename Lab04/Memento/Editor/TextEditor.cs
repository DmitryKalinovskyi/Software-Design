using Memento.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public partial class TextEditor
    {
        [MementoField]
        private TextDocument _textDocument;

        [MementoField]
        private int position { get; set; }

        public TextEditor()
        {
            _textDocument = new TextDocument(); 
        }
    }
}
