using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Editor
{
    public class TextDocument : ICloneable
    {
        public StringBuilder Text { get; set; }

        public TextDocument()
        {
            Text = new();
        }

        public object Clone()
        {
            var clone = new TextDocument
            {
                Text = new StringBuilder(Text.ToString())
            };

            return clone;
        }

        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
