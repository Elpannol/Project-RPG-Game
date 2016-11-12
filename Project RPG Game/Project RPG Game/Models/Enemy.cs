using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Game.Models
{
    class Enemy : Character
    {
        public Enemy(string name) : base(name)
        {
        }

        public override int RollDice(int sides)
        {
            Random random = new Random();
            int value = random.Next(sides) + 1;
            return value;
        }
    }
}
