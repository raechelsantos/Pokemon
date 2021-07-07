using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulbasaur blake_bulbasaur = new Bulbasaur("Blake");
            Bulbasaur julian_bulbasaur = new Bulbasaur("Julian");
            Charmander hunter_charmander = new Charmander("Hunter");

            julian_bulbasaur.Attack(blake_bulbasaur);
            julian_bulbasaur.Cry();
            hunter_charmander.Attack(blake_bulbasaur);
            hunter_charmander.Attack(blake_bulbasaur);
            hunter_charmander.Attack(blake_bulbasaur);
            hunter_charmander.Cry();
        }
    }
}
