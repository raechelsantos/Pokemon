using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name)
            : base(name)
        {
            if (name != null)
            {
                Name = name;
            }
            else
            {
                Name = "Bulbasaur";
            }
            Type = "Grass";
            MoveSet[0] = "Tackle";
            MoveSet[1] = "Growl";
        }

        public override void Cry()
        {
            Console.WriteLine($"\n{this.Name} says: Bulba Bulba!\n");
        }

        public override int Attack(Pokemon foe)
        {
            return base.Attack(foe);
        }
    }
}
