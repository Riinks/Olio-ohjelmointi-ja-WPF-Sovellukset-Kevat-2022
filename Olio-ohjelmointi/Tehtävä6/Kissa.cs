using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä6
{
    class Kissa : Eläin
    {
        public string Väri;   
        public int Ikä;   

        public static int instanssit = 0;

        public Kissa(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            instanssit++;         
        }

        public static new void KuinkaMonta()          
        {
            Console.WriteLine("Kissoja on elossa: " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Meow");
        }
    }
}