using System.Text;

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
