using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public class TextDocument : ICloneable
    {
        List<string> Text { get; set; }

        public TextDocument()
        {
            Text = new();
        }

        public object Clone()
        {
            var clone = new TextDocument();
            clone.Text = Text;
            return clone;
        }
    }
}
