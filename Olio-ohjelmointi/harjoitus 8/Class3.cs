using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_8
{
    abstract class Henkilö
    {
        private static int instanssit;

        public abstract string Nimi { get; set; }
        public abstract int Ikä { get; set; }
        public abstract int Henkilötunnus { get; set; }
         
        public virtual void Tulostatiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ", ikä: " + Ikä + ".henkilötunnus: " + Henkilötunnus);
        }
    }
}
