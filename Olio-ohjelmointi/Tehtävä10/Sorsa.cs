using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä10
{
    class Sorsa : Animal, ICanFly, ICanSwim
    {
        public float WingSize { get; set; }
        public float SwimSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            Console.WriteLine("Sorsa lentää. Sorsan perse on " + WingSize);
        }

        public void Swim()
        {
            Console.WriteLine("Sorsa ui. nopeus on " + SwimSpeed);
        }
    }
}
