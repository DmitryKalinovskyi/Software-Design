using Composite.Command;
using Composite.Core;
using Composite.Core.Elements;
using Composite.Core.Elements.Image;
using Composite.Core.Iterators;
using Composite.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateTemplate : LightHTMLCommand
    {
        public override void Execute(object? parameter)
        {
            var factory = new ExampleFactory();
            var root = (LightElementNode)factory.Create();

            foreach (var textNode in root.Where((node) => node is LightTextNode))
            {
                Console.WriteLine("Founded: " + textNode.GetOuterHTML());
                textNode.DoubleCliked += (sender, args) => Console.WriteLine("Event worked!");
                textNode.OnDoubleClick();
            }
        }
    }
}
