using Composite.Core.Elements;
using Composite.Core.Elements.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Visitor
{
    public class LightHTMLRenderer : ILightHTMLVisitor
    {
        public void Visit(ImageNode imageNode)
        {
            Console.WriteLine("Render image");
            imageNode.OnRender();
        }

        public void Visit(LightTextNode textNode)
        {
            Console.WriteLine("Render textNode");
            textNode.OnRender();
        }

        public void Visit(LightElementNode elementNode)
        {
            Console.WriteLine("Render composite element node");
            elementNode.OnRender();
        }
    }
}
