using Composite.Core.Elements;
using Composite.Core.Elements.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Visitor
{
    public class LightHTMLPreviewRenderer : ILightHTMLVisitor
    {
        public void Visit(ImageNode imageNode)
        {
            Console.WriteLine($"Preview of the image {imageNode.Href}");
            imageNode.OnRender();
        }

        public void Visit(LightTextNode textNode)
        {
            Console.WriteLine($"Preview of text {textNode.Text}");
            textNode.OnRender();
        }

        public void Visit(LightElementNode elementNode)
        {
            Console.WriteLine($"Preview of composite node");
            elementNode.OnRender();
        }
    }
}
