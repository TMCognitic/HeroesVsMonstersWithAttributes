namespace HeroesVsMonsters.Models
{
    public class LeatherAttribute : LootAttribute
    {
        public LeatherAttribute(int max = 4) : base("pièce(s) de cuirs", max)
        {
        }

        public LeatherAttribute(string contentName, int max = 4) : base(contentName, max)
        {
        }
    }
}
