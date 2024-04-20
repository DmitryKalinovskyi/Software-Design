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

        public int GetNextLine(int startIndex = 0)
        {
            while (startIndex < Text.Length)
            {
                if (Text[startIndex] == '\n')
                    return startIndex + 1;

                startIndex++;
            }

            return -1;
        }

        public int GetPreviousLine(int startIndex = 0)
        {
            int meeted = 0;

            while(startIndex > 0)
            {
                if (Text[startIndex] == '\n')
                {
                    meeted++;
                }

                if (meeted == 2) return startIndex + 1;

                startIndex--;
            }

            return 0;
        }

        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
