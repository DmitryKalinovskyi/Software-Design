namespace Memento.Editor
{
    public partial class TextEditor
    {
        public class EditorSnapshot
        {
            public TextDocument? TextDocument { get; set; }

            public override string ToString()
            {
                return TextDocument?.ToString() ?? "TextDocument not seted.";
            }
        }
    }
}
