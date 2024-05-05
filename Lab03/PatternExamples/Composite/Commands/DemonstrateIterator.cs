using Composite.Command;
using Composite.Core;
using Composite.Core.Elements;
using Composite.Core.Iterators;
using Composite.Factories;
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
            var factory = new ExampleFactory();

            var root = (LightElementNode)factory.Create();

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
