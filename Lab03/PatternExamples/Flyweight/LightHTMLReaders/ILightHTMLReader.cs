using Flyweight.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LightHTMLReaders
{
    public interface ILightHTMLReader
    {
        public LightNode ReadLightHTML(string path);
    }
}
