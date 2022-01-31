using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija
    {
        public string Nimi;
        public string OpiskelijaID;
        public int Opintopisteet;

        public void TulostaData()
        {
            Console.WriteLine("Opiskelijan nimi: " + Nimi + ". OpiskelijaID: " + OpiskelijaID + ". Opimntopisteet: " + Opintopisteet);
        }
        public void UwU()
        {
            Console.WriteLine("UwU");
        }
    }
}
