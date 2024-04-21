using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Elements.Image
{
    public class NetworkImageSource : IImageSource
    {
        public string GetImage(string uri)
        {
            return $"Loading from network by uri: {uri}";
        }
    }
}
