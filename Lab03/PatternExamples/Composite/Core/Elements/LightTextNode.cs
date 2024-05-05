namespace Composite.Core.Elements
{
    public class LightTextNode : LightElementNode
    {
        public string Text { get; set; }

        public LightTextNode()
        {
            Text = string.Empty;
        }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override void OnDoubleClick()
        {
            // copy text to the buffer of the user.
            Console.WriteLine("Copied Text to the buffer.");
            
            base.OnDoubleClick();
        }

        /// Methods below are used in recursive HTML generating. For leaf LigthTextNode it may looks empty but it's enough.

        public override IEnumerable<string> GetLazyInnerHTML()
        {
            // nothing inside text node.
            yield break;
        }

        public override IEnumerable<string> GetLazyOuterHTML()
        {
            yield return Text;
        }
    }
}
