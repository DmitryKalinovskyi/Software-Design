using Composite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Factories
{
    public interface ILightHTMLFactory
    {
        public LightNode Create();
    }
}
