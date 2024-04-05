using Proxy;
using Proxy.Proxy;
using System.Text.RegularExpressions;

var smartTextReader = new SmartTextReader();
var checker = new SmartTextCheker(smartTextReader);


checker.OpenFile("./test.txt");
checker.GetFileContent();
checker.CloseFile();

Console.WriteLine();


var checkerWithSecurity = new SmartTextReaderLocker(checker, new Regex("secure[.]txt$"));


try
{
    Console.WriteLine("Testing with security.");
    checkerWithSecurity.OpenFile("./secure.txt");
    checkerWithSecurity.GetFileContent();
    checkerWithSecurity.CloseFile();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




/*
 * Notice, that methods OpenFile and CloseFile added especially for proxy, to write info into console.
 * Another way is to keep only GetFileContent method and add events OnFileOpen, OnFileClose. Then proxy subscribes to that events to log info.
 * 
 */

