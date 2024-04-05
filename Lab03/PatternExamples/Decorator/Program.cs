using Decorator.Decorator;
using Decorator.Heroes;

var mage = new Mage("Dmytro Kalinovskyi");

Console.WriteLine(mage.GetInfo());

HeroDecorator decoratedMage = new ArmorDecorator(mage);
decoratedMage = new ArtefactDecorator(decoratedMage);
decoratedMage = new ArtefactDecorator(decoratedMage);

Console.WriteLine("Decorated varsion: ");
Console.WriteLine(decoratedMage.GetInfo());


/* another example of pattern use:
 * 
 * suppose you have IService and some implementation for that interface.
 * you can to test memory usage, time usage and network usage
 * 
 * then you just write a decorator for IService, abstract class ServiceDecorator for example
 * then you write several classes for each characteristic you want to measure
 * TimeMeasureDecorator
 * MemoryMeasureDecorator
 * NetworkMeauseDecorator
 */