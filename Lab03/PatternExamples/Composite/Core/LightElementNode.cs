namespace Composite.Core
{
    public partial class LightElementNode : LightNode
    {
        public List<LightNode> Children { get; set; }

        public LightElementNode()
        {
            TagName = "?";
            IsSelfClosing = false;
            Children = new List<LightNode>();
        }

        public LightElementNode(string tagName, bool isSelfClosing = false)
            : this(tagName, isSelfClosing, Enumerable.Empty<string>()) { }

        public LightElementNode(string tagName, bool isSelfClosing, IEnumerable<string> cSSClassList)
            : this(tagName, isSelfClosing, cSSClassList, Enumerable.Empty<LightNode>()){ }

        public LightElementNode(string tagName, bool isSelfClosing, IEnumerable<string> cSSClassList, IEnumerable<LightNode> children)
            : base(tagName, isSelfClosing, cSSClassList) 
        {
            Children = new(children);
        }

        protected virtual string GetHead()
        {
            return $"<{TagName} class=\"{string.Join(' ', CSSClassList)}\">";
        }

        public override IEnumerable<string> GetLazyInnerHTML()
        {
            // more simplified, we return step by step each htmlLine in each child.

            foreach (var child in Children)
            {
                foreach (var htmlLine in child.GetLazyOuterHTML())
                {
                    yield return htmlLine;
                }
            }
        }

        public override IEnumerable<string> GetLazyOuterHTML()
        {
            yield return GetHead();

            if (IsSelfClosing)
            {
                yield break;
            }

            foreach (var htmlLine in GetLazyInnerHTML())
            {
                yield return htmlLine;
            }

            yield return $"</{TagName}>";
        }
    }
}
