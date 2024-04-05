using Flyweight.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.FlyweightVersion
{
    public class LightElementNode_Flyweight : LightNode
    {
        public TagType TagType { get; set; }

        public HashSet<string> CSSClassList { get; set; }

        public List<LightNode> Children { get; set; }

        public LightElementNode_Flyweight()
        {
            TagType = TagType.Undefined;
            CSSClassList = new HashSet<string>();
            Children = new List<LightNode>();
        }

        public LightElementNode_Flyweight(TagType tagType)
        {
            TagType = tagType;
            CSSClassList = new();
            Children = new();
        }

        public LightElementNode_Flyweight(TagType tagType, List<string> cSSClassList)
        {
            TagType = tagType;
            CSSClassList = new(cSSClassList);
            Children = new();
        }

        public LightElementNode_Flyweight(TagType tagType, List<string> cSSClassList, List<LightNode> children)
        {
            TagType = tagType;
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
            return $"<{TagType.TagName} class=\"{string.Join(' ', CSSClassList)}\">";
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
