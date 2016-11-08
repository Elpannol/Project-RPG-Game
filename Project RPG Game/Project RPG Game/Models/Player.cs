using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Game.Models
{
    class Player : Character
    {
        public int Strenght { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public readonly string Race;

        public Player(string name, string race, int stenght, int agility, int endurance , int intelligence, int wisdom, int charisma) : base(name)
        {
            Strenght = stenght;
            Agility = agility;
            Endurance = endurance;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
            Race = race;
        }
    }
}
