using Composite.Core;
using Composite.Core.Elements;
using Composite.Core.Elements.Image;
using Composite.Core.Iterators;

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
foreach(var item in root.GetDFSIterator())
{
    Console.WriteLine(item.GetOuterHTML());
}

Console.WriteLine("BFS Iterator:");
foreach(var item in root.GetBFSIterator())
{
    Console.WriteLine(item.GetOuterHTML());
}

//void DemonstrateStrategy()
//{
//    var root = new LightElementNode("body");

//    root.Children.Add(new ImageNode("https://google.com/somepicture1"));
//    root.Children.Add(new ImageNode("folder1/happy.png", new FileImageSource()));


//    void DisplayLightNode(LightNode lightNode)
//    {
//        foreach (var line in lightNode.GetLazyOuterHTML())
//        {
//            Console.WriteLine(line);
//        }
//    }

//    DisplayLightNode(root);
//}

//root.OnClick += (sender, e) =>
//{
//    Console.WriteLine("You clicked to the body!");
//};

//var lambda = (LightElementNode node, EventArgs e) =>
//{
//    Console.WriteLine("This lambda should not be shown in the first time.");
//};

//root.OnClick += lambda;

//root.OnClick.Invoke(root, new EventArgs());

//root.OnClick -= lambda;
//root.OnClick.Invoke(root, new EventArgs());

//LightNode GenerateList(IEnumerable<string> listItems)
//{
//    var ol = new LightElementNode("ol");
//    foreach (var item in listItems)
//    {
//        var li = new LightElementNode("li");
//        li.Children.Add(new LightTextNode(item));

//        ol.Children.Add(li);
//    }

//    return ol;
//}

//var orderedList = GenerateList(new List<string> { "C#", "C++", "JavaScript", "TypeScript" });

//root.Children.Add(orderedList);

//foreach (var htmlLine in root.GetLazyOuterHTML())
//{
//    Console.WriteLine(htmlLine);
//}
