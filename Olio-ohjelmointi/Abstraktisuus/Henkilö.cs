using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }

        public abstract void Puhu();
    }
}
