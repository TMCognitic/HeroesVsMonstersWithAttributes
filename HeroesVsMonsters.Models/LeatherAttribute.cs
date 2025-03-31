namespace HeroesVsMonsters.Models
{
    public class LeatherAttribute : LootAttribute
    {
        public LeatherAttribute(int max = 4) : base("pièce(s) de cuirs", max, 1)
        {
        }

        public LeatherAttribute(string contentName, int max = 4) : base(contentName, max, 1)
        {
        }
    }
}
