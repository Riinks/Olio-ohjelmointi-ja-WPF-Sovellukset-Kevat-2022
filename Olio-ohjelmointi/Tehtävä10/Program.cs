using System;

namespace Tehtävä10
{
    class Program
    {
        static void Main(string[] args)
        {              
            Varis varis1 = new Varis(5);
            Sorsa sorsa1 = new Sorsa(4, 7);

            varis1.Fly();
            varis1.MakeASound();

            sorsa1.Fly();
            sorsa1.MakeASound();
            sorsa1.Swim();
        }
    }
}
