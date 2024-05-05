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

            root.OnClick += (sender, e) =>
            {
                Console.WriteLine("You clicked to the body!");
            };

            var lambda = (LightElementNode node, EventArgs e) =>
            {
                Console.WriteLine("This lambda should not be shown in the first time.");
            };

            root.OnClick += lambda;

            root.OnClick.Invoke(root, new EventArgs());

            root.OnClick -= lambda;
            root.OnClick.Invoke(root, new EventArgs());
        }
    }
}
