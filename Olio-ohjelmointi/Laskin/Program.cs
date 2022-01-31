using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 42;
            float b = 31;

            Console.WriteLine(Laskin.Summa(a, b));
            Console.WriteLine(Laskin.Erotus(a, b));
            Console.WriteLine(Laskin.Kertolasku(a, b));
            Console.WriteLine(Laskin.Jakolasku(a, b));
        }
    }
}
