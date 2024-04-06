using Flyweight.Core;

namespace Flyweight.LightHTMLReaders
{
    public class LightHTMLReader : ILightHTMLReader
    {
        public LightNode ReadLightHTML(string path)
        {
            using var sr = new StreamReader(path);
            var root = new LightElementNode("root");

            bool firstLineReaded = false;

            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine() ?? "";
                var textNode = new LightTextNode(line);

                LightElementNode node;
                if (firstLineReaded == false)
                {
                    node = new LightElementNode("h1", false);
                    firstLineReaded = true;
                }
                else if (line.Length < 20)
                {
                    node = new LightElementNode("h2", false);
                }
                else if (line[0] == ' ')
                {
                    node = new LightElementNode("h2", false);
                }
                else
                {
                    node = new LightElementNode("p", false);

                }

                node.Children.Add(textNode);
                root.Children.Add(node);
            }

            return root;
        }
    }
}
