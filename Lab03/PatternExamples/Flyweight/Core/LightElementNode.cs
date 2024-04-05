using Flyweight.FlyweightVersion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Core
{
    public class LightElementNode: LightNode
    {
        private string _tagName = "";
        public string TagName
        {
            get => _tagName;
            set
            {
                _tagName = value.ToLower();
            }
        }

        public bool IsSelfClosing { get; set; }

        public List<string> CSSClassList { get; set; }

        public List<LightNode> Children { get; set; }

        public LightElementNode()
        {
            TagName = "?";
            IsSelfClosing = false;
            CSSClassList = new List<string>();
            Children = new List<LightNode>();
        }

        public LightElementNode(string tagName, bool isSelfClosing = false)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
            CSSClassList = new();
            Children = new();
        }

        public LightElementNode(string tagName, bool isSelfClosing, List<string> cSSClassList)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
            CSSClassList = cSSClassList;
            Children = new();
        }

        public LightElementNode(string tagName, bool isSelfClosing, List<string> cSSClassList, List<LightNode> children)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
            CSSClassList = cSSClassList;
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
