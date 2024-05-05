using Composite.Core;
using Composite.Core.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Factories
{
    public class ExampleFactory : ILightHTMLFactory
    {
        public LightNode Create()
        {
            var root = new LightElementNode("body");

            LightElementNode GenerateList(IEnumerable<string> listItems)
            {
                var ol = new LightElementNode("ol");
                foreach (var item in listItems)
                {
                    var li = new LightElementNode("li");
                    li.Children.Add(new LightTextNode(item));

                    ol.Children.Add(li);
                }

                return ol;
            }

            var orderedList = GenerateList(new List<string> { "C#", "C++", "JavaScript", "TypeScript" });

            root.Children.Add(orderedList);

            return root;
        }
    }
}
