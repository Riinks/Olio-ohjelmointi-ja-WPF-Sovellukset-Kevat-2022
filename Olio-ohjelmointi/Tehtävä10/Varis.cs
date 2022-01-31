using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä10
{
    class Varis : Animal, ICanFly
    {
        public Varis(float wingSize)
        {
            WingSize = wingSize;
        }

        public float WingSize { get; set; }

        public void Fly()
        {
            Console.WriteLine("Varis lentää. Variksen siipien koko on " + WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("KakaaW Kakaaw");
        }
    }
}
