using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Iterators
{
    public class DFSIterator : ILightHTMLIterator
    {
        private LightElementNode _root;

        public DFSIterator(LightElementNode root) 
        {
            _root = root;
        }

        public LightNode? GetNext()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }
    }

    public static class DFSIteratorExtension
    {
        // extension method for the LightElementNode
        public static ILightHTMLIterator GetDFSIterator(this LightElementNode node)
        {
            return new DFSIterator(node);
        }
    }
}
