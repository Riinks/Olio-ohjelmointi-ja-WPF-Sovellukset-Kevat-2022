using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_8
{
    class Työntekijä : Henkilö
    {
        public int palkka;

        public Työntekijä(int palkka, string nimi, int ikä, int henkilötunnus)
        {
            this.palkka = palkka;
            Nimi = nimi;
            Ikä = ikä;
            Henkilötunnus = henkilötunnus;
        }

        public override string Nimi { get; set; }
        public override int Ikä { get; set; }
        public override int Henkilötunnus { get; set; }
    }
}
