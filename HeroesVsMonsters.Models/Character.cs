using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public abstract class Character
    {
        protected Dice D4 { get; }
        protected Dice D6 { get; }

        public Character()
        {
            D4 = new Dice(4);
            D6 = new Dice(6);
        }
    }
}
