using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    private static int Instanssit = 0;

    public Henkilö(string nimi, int ikä)
    {
        public string Nimi;
        public int Ikä;
        public int Henkilötunnus;

        Instanssit++;
        }

        public virtual void TulostaTiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ", Ikä: " + Ikä + ", Henkilötunnus: " + Henkilötunnus);
        }
    }
}
