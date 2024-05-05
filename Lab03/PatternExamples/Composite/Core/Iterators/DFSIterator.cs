using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Iterators
{
    public class DFSIterator : ILightHTMLIterator
    {
        private IEnumerator<LightNode> _enumerator;

        public DFSIterator(LightElementNode root) 
        {
            _enumerator = DFSGenerator(root).GetEnumerator();
        }

        /// <summary>
        /// Recursive enumerator (generator), that implements depth-first search traversal in the lightHtml.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private IEnumerable<LightNode> DFSGenerator(LightNode node)
        {
            // start from the root node
            yield return node;

            // we can use only LightElementNode, because it's base class for all composite elements.
            if(node is LightElementNode lightElementNode)
            {
                // then iterate by child
                foreach(var child in lightElementNode.Children)
                {
                    
                    foreach(var c in DFSGenerator(child))
                    {
                        yield return c;
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _enumerator;
        }

        IEnumerator<LightNode> IEnumerable<LightNode>.GetEnumerator()
        {
            return _enumerator;
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
