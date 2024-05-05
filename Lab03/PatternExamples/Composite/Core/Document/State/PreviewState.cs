using Composite.Core.Iterators;
using Composite.Core.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Document.State
{
    public class PreviewState : IDocumentState
    {
        private LightHTMLDocument _lightHTMLDocument;

        public PreviewState(LightHTMLDocument document)
        {
            _lightHTMLDocument = document;
        }

        public void Render()
        {
            var renderer = new LightHTMLPreviewRenderer();
           
            foreach(var child in _lightHTMLDocument.RootNode.GetBFSIterator())
            {
                child.Accept(renderer);
            }
        }
    }
}
