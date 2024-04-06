using Composite.Core;

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

foreach (var htmlLine in root.GetLazyOuterHTML())
{
    Console.WriteLine(htmlLine);
}
