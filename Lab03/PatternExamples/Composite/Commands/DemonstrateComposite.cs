using Composite.Command;
using Composite.Core;
using Composite.Core.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateComposite : LightHTMLCommand
    {
        public override void Execute(object? parameter)
        {
            var root = new LightElementNode("body");

            LightNode GenerateList(IEnumerable<string> listItems)
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

            foreach (var htmlLine in root.GetLazyOuterHTML())
            {
                Console.WriteLine(htmlLine);
            }
        }
    }
}
