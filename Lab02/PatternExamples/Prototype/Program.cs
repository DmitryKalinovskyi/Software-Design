// virus family can be represented as tree data structure.
// clonning of the virus is the same that clonning subtree


using Prototype;

var typeA = new VirusType("A");
var typeB = new VirusType("B");
var typeC = new VirusType("C");

var root = new Virus("Virus1", 100, new DateTime(2020, 3, 24), typeA);
var child1 = new Virus("Virus1-1", 149, new DateTime(2021, 3, 24), typeB);
var child2 = new Virus("Virus1-2", 200, new DateTime(2022, 3, 24), typeC);

root.Children.Add(child1);
root.Children.Add(child2);

Console.WriteLine(root.GetInfo());

var clonedRoot = (Virus)root.Clone();

Console.Write(clonedRoot.GetInfo());