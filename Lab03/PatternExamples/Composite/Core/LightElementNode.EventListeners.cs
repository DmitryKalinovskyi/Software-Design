using Composite.Core.Observer;

namespace Composite.Core
{
    public partial class LightElementNode
    {
        /*
         * it can be done with c# build in event sytem
         * public event EventHandler<EventArgs> OnClick
         * public event EventHandler<EventArgs> OnButtonDown
         * public event EventHandler<EventArgs> OnButtonUp
         * public event EventHandler<EventArgs> OnMouseOver
         */

        // for this example i will ignore event listener interface, i just use lambda functions.

        public EventManager<LightElementNode, EventArgs> OnClick = new();
        public EventManager<LightElementNode, EventArgs> OnButtonDown = new();
        public EventManager<LightElementNode, EventArgs> OnButtonUp = new();
        public EventManager<LightElementNode, EventArgs> OnButtonOver = new();
    }
}
