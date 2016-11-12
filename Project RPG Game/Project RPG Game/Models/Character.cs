using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Game.Models
{
    abstract class Character
    {
        public readonly string Name;
        public Character(string name)
        {
            Name = name;
        }

        public abstract int RollDice(int sides);
    }

}
