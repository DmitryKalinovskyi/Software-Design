using Composite.Core;

var root = new LightElementNode("body");

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
