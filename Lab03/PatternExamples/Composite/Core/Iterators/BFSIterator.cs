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
        private IEnumerator<LightNode> _enumerator;

        public BFSIterator(LightElementNode root)
        {
            _enumerator = BFSGenerator(root).GetEnumerator();
        }

        private IEnumerable<LightNode> BFSGenerator(LightNode node)
        {
            var queue = new Queue<LightNode>();
            queue.Enqueue(node);

            while(queue.Count > 0)
            {
                var front = queue.Dequeue();
                yield return front;

                // add children to the queue
                if(front is LightElementNode lightElementNode)
                {
                    foreach(var child in lightElementNode.Children)
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            return _enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _enumerator;
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
