using Composite.Core.Elements;
using Composite.Core.Elements.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Visitor
{
    public interface ILightHTMLVisitor
    {
        public void Visit(ImageNode imageNode);
        
        public void Visit(LightTextNode textNode);
       
        public void Visit(LightElementNode elementNode);
    }
}
