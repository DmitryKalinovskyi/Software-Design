using Composite.Core.Iterators;
using Composite.Core.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Document.State
{
    public class ViewState : IDocumentState
    {
        private readonly LightHTMLDocument _lightHTMLDocument;

        public ViewState(LightHTMLDocument lightHTMLDocument)
        {
            _lightHTMLDocument = lightHTMLDocument;
        }

        public void Render()
        {
            var renderer = new LightHTMLRenderer();

            foreach(var child in _lightHTMLDocument.RootNode.GetBFSIterator())
            {
                child.Accept(renderer);
            }
        }
    }
}
