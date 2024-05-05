using Composite.Core.Document.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Document
{
    public class LightHTMLDocument: IDocumentState
    {
        public IDocumentState DocumentState { get; private set; }

        public LightElementNode RootNode { get; set; }

        public void SetState(IDocumentState state)
        {
            DocumentState = state;
        }

        public void Render()
        {
            DocumentState.Render();
        }

        public LightHTMLDocument() 
        {
            DocumentState = new ViewState(this);
            RootNode = new LightElementNode("body");
        }

        public LightHTMLDocument(LightElementNode root)
        {
            DocumentState = new ViewState(this);
            RootNode = root;
        }
    }
}
