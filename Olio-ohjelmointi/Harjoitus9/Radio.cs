using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus9
{
    class Radio
    {
        public bool OnOff = true;
        private int maksimiÄänenvoimakkuus = 9;
        private int minimiÄänenvoimakkuus = 0;
        private float maksimiTaajuus = 107.9f;
        private float minimiTaajuus = 88.0f;
        private int äänenvoimakkuus;  

        public int Äänenvoimakkuus    
        {
            get { return äänenvoimakkuus; }     
            set
            {
                if (value > maksimiÄänenvoimakkuus)
                {
                    äänenvoimakkuus = maksimiÄänenvoimakkuus;
                }
                else if (value < minimiÄänenvoimakkuus)
                {
                    äänenvoimakkuus = minimiÄänenvoimakkuus;
                }
                else
                {
                    äänenvoimakkuus = value;
                }
                
            } 
        }

        private float taajuus;

        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value > maksimiTaajuus)
                {
                    taajuus = maksimiTaajuus;
                }
                else if (value < minimiTaajuus)
                {
                    taajuus = minimiTaajuus;
                }
                else
                {
                    taajuus = value;
                }
            }
        }
    }
}

