﻿using FurnitureDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Victorian
{
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void Show()
        {
            Console.WriteLine("\t\tVictorian Coffee Table");
        }
    }
}
