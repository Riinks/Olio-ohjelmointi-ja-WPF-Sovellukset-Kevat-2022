using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä10
{
    interface ICanFly
    {
        public float WingSize { get; set; }

        public void Fly();
    }
}
