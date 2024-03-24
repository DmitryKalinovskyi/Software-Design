
using Builder;

var director = new Director();

var hero = director.BuildMyDreamHero();
var enemy = director.BuildArchEnemy();

Console.WriteLine("Hero: ");
Console.WriteLine(hero.GetInfo());
Console.WriteLine();

Console.WriteLine("Enemy: ");
Console.WriteLine(enemy.GetInfo());
Console.WriteLine();