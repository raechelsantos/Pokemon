using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Squirtle : Pokemon
    {
        public Squirtle(string name)
            : base(name)
        {
            if (name != null)
            {
                Name = name;
            }
            else
            {
                Name = "Squirtle";
            }
            Type = "Water";
            MoveSet[0] = "Tackle";
            MoveSet[1] = "Tail Whip";
        }

        public void Cry()
        {
            Console.WriteLine($"\n{this.Name} says: Squirtle Squirtle!\n");
        }
    }
}
