using FurnitureDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Modern
{
    public class ModernSofa : ISofa
    {
        public void Show()
        {
            Console.WriteLine("\t\tModern Sofa");
        }
    }
}
