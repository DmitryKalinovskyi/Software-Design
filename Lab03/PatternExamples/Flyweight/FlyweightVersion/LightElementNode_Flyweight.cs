using Flyweight.Core;

namespace Flyweight.FlyweightVersion
{
    public class LightElementNode_Flyweight : LightNode
    {
        public TagType TagType { get; set; }

        public List<string> CSSClassList { get; set; }

        public List<LightNode> Children { get; set; }

        public LightElementNode_Flyweight()
        {
            TagType = TagType.Undefined;
            CSSClassList = new();
            Children = new List<LightNode>();
        }

        public LightElementNode_Flyweight(TagType tagType) : this(tagType, new(), new()) { }

        public LightElementNode_Flyweight(TagType tagType, List<string> cSSClassList) : this(tagType, cSSClassList, new()) { }

        public LightElementNode_Flyweight(TagType tagType, List<string> cSSClassList, List<LightNode> children)
        {
            TagType = TagTypeFactory.Instance.GetCached(tagType);
            CSSClassList = new(cSSClassList);
            Children = children;
        }

        public override string GetInnerHTML()
        {
            return string.Join("", GetLazyInnerHTML());
        }

        public override string GetOuterHTML()
        {
            return string.Join("", GetLazyOuterHTML());
        }

        protected virtual string GetHead()
        {
            return $"<{(TagType.IsSemantic ? '!' : ' ')}{TagType.TagName} class=\"{string.Join(' ', CSSClassList)}\">";
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

            if (TagType.IsSelfClosing)
            {
                yield break;
            }

            foreach (var htmlLine in GetLazyInnerHTML())
            {
                yield return htmlLine;
            }

            yield return $"</{TagType.TagName}>";
        }
    }
}
