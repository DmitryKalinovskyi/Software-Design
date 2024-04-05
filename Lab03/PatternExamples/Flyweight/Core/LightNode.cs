using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Core
{
    public abstract class LightNode
    {
        public abstract string GetInnerHTML();

        public abstract string GetOuterHTML();

        public abstract IEnumerable<string> GetLazyInnerHTML();

        public abstract IEnumerable<string> GetLazyOuterHTML();
    }
}
