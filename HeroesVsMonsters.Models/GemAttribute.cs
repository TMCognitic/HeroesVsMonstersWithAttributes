namespace HeroesVsMonsters.Models
{
    public class GemAttribute : LootAttribute
    {
        public GemAttribute(int max = 8, int minLevel = 1) : base("gemme(s)", max, minLevel)
        {
        }
    }
}
