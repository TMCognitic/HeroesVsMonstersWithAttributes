using System.Reflection;

namespace HeroesVsMonsters.Models
{
    public class Hero : Character
    {
        public void Loot(Monster monster)
        {
            Console.WriteLine($"je lot un {monster.GetType().Name}");

            IEnumerable<LootAttribute> lootAttributes = monster.GetType().GetCustomAttributes<LootAttribute>();

            foreach(LootAttribute attribute in lootAttributes)
            {
                if(attribute.MinLevel <= monster.Level)
                    Console.WriteLine(attribute);
            }

            Console.WriteLine();
        }
    }
}
