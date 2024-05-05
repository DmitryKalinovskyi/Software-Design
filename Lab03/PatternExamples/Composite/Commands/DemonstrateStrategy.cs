using Composite.Command;
using Composite.Core;
using Composite.Core.Elements.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class DemonstrateStrategy : LightHTMLCommand
    {
        public override void Execute(object? parameter)
        {
            var root = new LightElementNode("body");

            root.Children.Add(new ImageNode("https://google.com/somepicture1"));
            root.Children.Add(new ImageNode("folder1/happy.png", new FileImageSource()));


            void DisplayLightNode(LightNode lightNode)
            {
                foreach (var line in lightNode.GetLazyOuterHTML())
                {
                    Console.WriteLine(line);
                }
            }

            DisplayLightNode(root);
        }
    }
}
