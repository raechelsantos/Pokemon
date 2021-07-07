using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public abstract class Pokemon
    {
        internal string Name { get; set; }
        internal string Type { get; set; }
        internal int Level { get; set; }
        internal int HP { get; set; }
        internal int Atk { get; set; }
        internal int Def { get; set; }
        internal int Exp { get; set; }
        internal string[] MoveSet = new string[4];

        public Pokemon(string name)
        {
            this.Name = name;
            this.Level = 5;
            this.HP = 20;
            this.Atk = 11;
            this.Def = 10;
            this.Exp = 0;
        }
        public int Attack(Pokemon foe)
        {
            foe.HP -= this.Atk / 2;
            Console.WriteLine($"{this.Name} used {MoveSet[0]}!\n{foe.Name} lost {this.Atk / 2} HP. {foe.Name}'s HP is now at {foe.HP}.");
            return foe.HP;
        }
    }
}
