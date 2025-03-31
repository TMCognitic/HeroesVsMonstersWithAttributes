using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Dice
    {
        private int _max;

        public int Next()
        {
            return Random.Shared.Next(_max) + 1;
        }

        public Dice(int max)
        {
            _max = max;
        }
    }
}
