using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Iterators
{
    public class BFSIterator : ILightHTMLIterator
    {
        private LightElementNode _root;

        public BFSIterator(LightElementNode root)
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

    public static class BFSIteratorExtension
    {
        public static ILightHTMLIterator GetBFSIterator(this LightElementNode node)
        {
            return new BFSIterator(node);
        }
    }
}
