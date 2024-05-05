using System.Collections.ObjectModel;

namespace Composite.Core
{
    public abstract class LightNode
    {
        // Template for the children.

        public virtual string? TagName { get; set; }

        public bool IsSelfClosing { get; set; }

        public readonly ObservableCollection<string> CSSClassList;

        public LightNode()
        {
            CSSClassList = new ObservableCollection<string>();
        }

        public LightNode(string? tagName, bool isSelfClosing, IEnumerable<string> cSSClassList)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
            CSSClassList = new(cSSClassList);
        }

        public virtual string GetInnerHTML()
        {
            return string.Join("", GetLazyInnerHTML());
        }

        public virtual string GetOuterHTML()
        {
            return string.Join("", GetLazyOuterHTML());
        }

        public abstract IEnumerable<string> GetLazyInnerHTML();

        public abstract IEnumerable<string> GetLazyOuterHTML();

        // lifecycle hooks

        //public abstract void OnRender();
    }
}
