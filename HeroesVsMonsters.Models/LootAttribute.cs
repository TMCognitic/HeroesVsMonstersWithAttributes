namespace HeroesVsMonsters.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class LootAttribute : Attribute
    {
        private readonly int _max;
        public int MinLevel { get; }

        public int Quantity { get { return Random.Shared.Next(_max) + 1; } }
        protected string ContentName { get; }

        public LootAttribute(string contentName, int max, int minLevel)
        {
            ContentName = contentName;
            _max = max;
            MinLevel = minLevel;
        }

        public override string ToString()
        {
            return $"Je ramasse {Quantity} {ContentName}";
        }
    }
}
