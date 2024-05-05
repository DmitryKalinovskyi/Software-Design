using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Iterators
{
    public class FilterIterator : ILightHTMLIterator
    {
        private Predicate<LightNode> _predicate;
        private IEnumerator<LightNode> _enumerator;
        private ILightHTMLIterator _iterationManner;

        public FilterIterator(Predicate<LightNode> predicate, ILightHTMLIterator iterationManner)
        {
            _predicate = predicate;
            _iterationManner = iterationManner;

            _enumerator = Filter().GetEnumerator();
        }

        private IEnumerable<LightNode> Filter()
        {
            foreach (var item in _iterationManner)
            {
                if (_predicate(item)) yield return item;
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

    public static class FilterIteratorExtension
    {
        /// <summary>
        /// Returns iterator to the nodes in the LightHTMLTree, where nodes satisfy predicate
        /// </summary>
        /// <param name="node"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static ILightHTMLIterator Where(this LightElementNode node, Predicate<LightNode> predicate)
        {
            return new FilterIterator(predicate, node.GetDFSIterator());
        }

        /// <summary>
        /// Returns iterator to the nodes in the LightHTMLTree, where nodes satisfy predicate
        /// </summary>
        /// <param name="node"></param>
        /// <param name="predicate"></param>
        /// <param name="iterationManner"></param>
        /// <returns></returns>
        public static ILightHTMLIterator Where(this LightElementNode node, Predicate<LightNode> predicate, ILightHTMLIterator iterationManner)
        {
            return new FilterIterator(predicate, iterationManner);
        }
    }
}