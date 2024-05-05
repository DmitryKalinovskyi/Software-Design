using System;
using System.Collections;
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

        public IEnumerator<LightNode> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public LightNode? GetNext()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
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
