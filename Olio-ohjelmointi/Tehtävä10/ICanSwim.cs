﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä10
{
    interface ICanSwim
    {
        public float SwimSpeed { get; set; }

        public void Swim();
    }
}
