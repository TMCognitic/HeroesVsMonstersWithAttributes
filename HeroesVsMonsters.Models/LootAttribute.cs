namespace HeroesVsMonsters.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class LootAttribute : Attribute
    {
        private readonly int _max;

        public int Quantity { get { return Random.Shared.Next(_max) + 1; } }
        protected string ContentName { get; }

        public LootAttribute(string contentName, int max)
        {
            ContentName = contentName;
            _max = max;
        }

        public override string ToString()
        {
            return $"Je ramasse {Quantity} {ContentName}";
        }
    }
}
