using Composite.Command;
using Composite.Core.Visitor;
using Composite.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateVisitor : LightHTMLCommand
    {
        public override void Execute(object? parameter)
        {
            var factory = new ExampleFactory();
            var root = factory.Create();
            var renderer = new LightHTMLRenderer();
            root.Accept(renderer);
        }
    }
}
