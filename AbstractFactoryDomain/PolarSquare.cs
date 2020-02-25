﻿using AbstractFactoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDomain
{
    public class PolarSquare : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing PolarSquare");
        }
    }
}
