using Flyweight.Core;
using Flyweight.FlyweightVersion;

namespace Flyweight.LightHTMLReaders
{
    public class LightHTMLReader_Flyweight : ILightHTMLReader
    {
        public TagTypeFactory TagTypeFactory { get; private set; }

        public LightHTMLReader_Flyweight()
        {
            TagTypeFactory = new TagTypeFactory();
        }


        public LightNode ReadLightHTML(string path)
        {
            using var sr = new StreamReader(path);
            var root = new LightElementNode_Flyweight(TagTypeFactory.GetCached(new TagType("root")));

            bool firstLineReaded = false;

            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine() ?? "";
                var textNode = new LightTextNode(line);

                LightElementNode_Flyweight node;
                if (firstLineReaded == false)
                {
                    node = new LightElementNode_Flyweight(TagTypeFactory.GetCached(new TagType("h1")));
                    firstLineReaded = true;
                }
                else if (line.Length < 20)
                {
                    node = new LightElementNode_Flyweight(TagTypeFactory.GetCached(new TagType("h2")));
                }
                else if (line[0] == ' ')
                {
                    node = new LightElementNode_Flyweight(TagTypeFactory.GetCached(new TagType("blockquote")));
                }
                else
                {
                    node = new LightElementNode_Flyweight(TagTypeFactory.GetCached(new TagType("p")));

                }

                node.Children.Add(textNode);
                root.Children.Add(node);
            }

            return root;
        }
    }
}
