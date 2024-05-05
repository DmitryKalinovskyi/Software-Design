using Composite.Command;
using Composite.Core;
using Composite.Core.Elements;
using Composite.Core.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateIterator : LightHTMLCommand
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

            Console.WriteLine("DFS Iterator:");
            foreach (var item in root.GetDFSIterator())
            {
                Console.WriteLine(item.GetOuterHTML());
            }

            Console.WriteLine("BFS Iterator:");
            foreach (var item in root.GetBFSIterator())
            {
                Console.WriteLine(item.GetOuterHTML());
            }

            Console.WriteLine("Filtering nodes:");
            foreach (var item in root.Where((node) => node is LightTextNode))
            {
                Console.WriteLine(item.GetOuterHTML());
            }

        }
    }
}
