using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Charmander : Pokemon
    {
        public Charmander(string name)
            : base(name)
        {
            if (name != null)
            {
                Name = name;
            }
            else
            {
                Name = "Charmander";
            }
            Type = "Fire";
            MoveSet[0] = "Scratch";
            MoveSet[1] = "Growl";
        }

        public void Cry()
        {
            Console.WriteLine($"\n{this.Name} says: Char Char!\n");
        }
    }
}
