using Composite.Command;
using Composite.Core;
using Composite.Core.Document;
using Composite.Core.Document.State;
using Composite.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateState : LightHTMLCommand
    {
        public override void Execute(object? parameter)
        {
            var factory = new ExampleFactory();
            var root = (LightElementNode)factory.Create();

            var document = new LightHTMLDocument(root);

            Console.WriteLine("View State.");
            document.Render();

            // change state to preview.
            document.SetState(new PreviewState(document));

            Console.WriteLine("Preview State.");
            document.Render();
        }
    }
}
