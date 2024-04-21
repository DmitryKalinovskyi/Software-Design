namespace Memento.Editor
{
    public partial class TextEditor
    {
        public interface IEditorSnapshot { }

        public class EditorSnapshot: IEditorSnapshot
        {
            public TextDocument? TextDocument { get; set; }

            public override string ToString()
            {
                return TextDocument?.ToString() ?? "TextDocument not seted.";
            }
        }
    }
}
