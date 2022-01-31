using System;

namespace Harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            if(radio.OnOff == true)
            {
                Console.WriteLine("Radio on päällä.");
            }
            else if(radio.OnOff == false)
            {
                Console.WriteLine("Radio ei ole päällä.");
            }

            radio.Äänenvoimakkuus = 3;
            Console.WriteLine("Radion Äänenvoimakkuus on " + radio.Äänenvoimakkuus.ToString());

            radio.Taajuus = 91.8f;
            Console.WriteLine("Radion Taajuus on " + radio.Taajuus.ToString());
        }
    }
}
