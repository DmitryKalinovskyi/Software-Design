using Flyweight.Core;
using Flyweight.FlyweightVersion;
using Flyweight.LightHTMLReaders;

long GetRAM()
{
    // gives allocated memory for all objects.
    return GC.GetTotalMemory(true);

    // gives current allocated memory for the process.
    //Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
    //return currentProcess.WorkingSet64;
}

void ShowLightHTMLPreview(LightNode lightNode, int lines = 5)
{
    int i = 0;
    foreach (var line in lightNode.GetLazyOuterHTML())
    {
        if (i >= lines)
        {
            break;
        }

        Console.WriteLine(line);

        i++;
    }
    Console.WriteLine("...");
}

void MeasureLightHTMLRam(ILightHTMLReader lightHTMLReader, string path)
{
    long ramBefore = GetRAM();
    var root = lightHTMLReader.ReadLightHTML(path);
    long ramAfter = GetRAM();
    long used = ramAfter - ramBefore;

    Console.WriteLine($"Used RAM: {used}");

    Console.WriteLine("LightNode preview:");
    ShowLightHTMLPreview(root);
}

string bookPath = "./book.txt";

var task1 = new Task(() =>
{
    Console.WriteLine("Without flyweight pattern");

    // around 1.57 mb
    MeasureLightHTMLRam(new LightHTMLReader(), bookPath);
});

var task2 = new Task(() =>
{
    Console.WriteLine("Using flyweight pattern:");

    // around 1.53 mb
    MeasureLightHTMLRam(new LightHTMLReader_Flyweight(), bookPath);

    Console.WriteLine($"Count of cached elements: {TagTypeFactory.Instance.CountOfCachedTags}");
    foreach (var tagType in TagTypeFactory.Instance.GetCachedTags())
    {
        Console.WriteLine(tagType.GetInfo());
    }
});

task1.Start();
task1.Wait();

Console.WriteLine("\n--------------------------------------------------");

task2.Start();
task2.Wait();

/* In conclusion, we don't achieve massive memory boost, because Flyweight becomes in hand when object have many different properties.
 * In this case, we have tag name, tag enclosing type and IsSemantic property. Most valuable property is name,
 * because it string type, but most of the tags contains only 1-2 characters (1-2 bytes). Boolean is one byte. In all objects properties take 4-6 bytes.
 * Count of generated objects around 5k, when we move intristic state to another class, we decrease memory usage at most 30k (6bytes * 5k) bytes.
 * As we can see from results.
 * 
 * Before flyweight (1.57mb) -> After flyweight (1.53mb)
 */
