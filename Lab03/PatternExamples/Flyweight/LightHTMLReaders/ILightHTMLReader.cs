using Flyweight.Core;

namespace Flyweight.LightHTMLReaders
{
    public interface ILightHTMLReader
    {
        public LightNode ReadLightHTML(string path);
    }
}
