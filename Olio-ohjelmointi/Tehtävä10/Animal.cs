using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä10
{
    class Animal
    {
        public string Nimi;

        public virtual void MakeASound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
}
