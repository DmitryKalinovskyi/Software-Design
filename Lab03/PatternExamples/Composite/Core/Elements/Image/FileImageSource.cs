using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Elements.Image
{
    public class FileImageSource : IImageSource
    {
        public string GetImage(string uri)
        {
            return $"Loading file with uri: {uri}";
        }
    }
}
