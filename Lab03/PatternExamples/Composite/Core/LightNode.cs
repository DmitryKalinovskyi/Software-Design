using Composite.Core.Observer;
using Composite.Core.Visitor;
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

        public abstract void Accept(ILightHTMLVisitor visitor);

        // lifecycle hooks

        /* events
         * it can be done with c# build in event sytem
         * for this example i will ignore event listener interface, i just use lambda functions.
         */

        public virtual void OnClick() 
        {
            Clicked.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnDoubleClick()
        {
            DoubleCliked.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnFocus()
        {
            Focused.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnUnfocus()
        {
            Unfocused.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnHoverIn()
        {
            HoveredIn.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnHoverOut()
        {
            HoveredOut.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnRender()
        {
            Rendered.Invoke(this, EventArgs.Empty);
        }

        public EventManager<LightNode, EventArgs> Clicked = new();
        public EventManager<LightNode, EventArgs> DoubleCliked = new();
        public EventManager<LightNode, EventArgs> Focused = new();
        public EventManager<LightNode, EventArgs> Unfocused = new();

        public EventManager<LightNode, EventArgs> HoveredIn = new();
        public EventManager<LightNode, EventArgs> HoveredOut = new();
        public EventManager<LightNode, EventArgs> Rendered = new();
    }
}
