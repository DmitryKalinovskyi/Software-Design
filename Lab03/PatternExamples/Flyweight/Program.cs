using Flyweight.Core;
using Flyweight.LightHTMLReaders;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

long GetRAM()
{
    Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
    return currentProcess.WorkingSet64;
}

void ShowLightHTMLPreview(LightNode lightNode, int lines = 10)
{
    int i = 0;
    foreach(var line in lightNode.GetLazyOuterHTML())
    {
        if(i >= lines)
        {
            break;
        }

        Console.WriteLine(line);

        i++;
    }
}

string bookPath = "./book.txt";

var task1 = new Task(() =>
{

    // test without flyweight pattern.
    long ramBefore = GetRAM();
    var htmlReader = new LightHTMLReader();
    var root = htmlReader.ReadLightHTML(bookPath);
    long ramAfter = GetRAM();

    long used = ramAfter - ramBefore;
    Console.WriteLine($"USED RAM: {used}");
    ShowLightHTMLPreview(root);

    // around 2.7 mb
});

var task2 = new Task(() =>
{
    // flyweight pattern
    long ramBefore = GetRAM();
    var htmlReader = new LightHTMLReader_Flyweight();
    var root = htmlReader.ReadLightHTML(bookPath);
    long ramAfter = GetRAM();

    long used = ramAfter - ramBefore;
    Console.WriteLine($"Count of cached elements: {htmlReader.TagTypeFactory.CountOfCachedTags}");
    foreach( var tagType in htmlReader.TagTypeFactory.GetCachedTags())
    {
        Console.WriteLine(tagType.GetInfo());
    }
    Console.WriteLine($"USED RAM: {used}");
    ShowLightHTMLPreview(root);

    // around 1 mb
});

task1.Start();
task1.Wait();
task2.Start();
task2.Wait();
