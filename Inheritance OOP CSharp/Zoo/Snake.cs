﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Snake : Reptile
    {
        public Snake(string name):base(name)
        {

        }

        public string Name { get; set; }
    }
}
