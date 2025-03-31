namespace HeroesVsMonsters.Models
{
    public abstract class Monster : Character
    {
        public int Level { get; set; } = 1;
    }
}
