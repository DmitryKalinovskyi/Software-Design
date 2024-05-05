using Composite.Command;
using Composite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateObserver : LightHTMLCommand
    {
        public override void Execute(object? parameter)
        {
            var root = new LightElementNode("root");

            root.Clicked += (sender, e) =>
            {
                Console.WriteLine("You clicked to the body!");
            };

            var lambda = (LightNode node, EventArgs e) =>
            {
                Console.WriteLine("This lambda should not be shown in the first time.");
            };

            root.Clicked += lambda;

            root.Clicked.Invoke(root, new EventArgs());

            root.Clicked -= lambda;
            root.Clicked.Invoke(root, new EventArgs());
        }
    }
}
