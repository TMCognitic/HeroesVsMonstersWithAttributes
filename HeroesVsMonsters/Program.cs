// See https://aka.ms/new-console-template for more information

using HeroesVsMonsters.Models;

Console.WriteLine("Hello, World!");

Hero hero = new Hero();

Monster[] monsters = [new Dragon(), new Orc(), new Wolf()];

foreach (Monster monster in monsters)
{
    hero.Loot(monster);
}