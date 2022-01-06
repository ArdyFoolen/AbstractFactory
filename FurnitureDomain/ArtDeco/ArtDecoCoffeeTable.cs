using FurnitureDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.ArtDeco
{
    public class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void Show()
        {
            Console.WriteLine("\t\tArt Deco Coffee Table");
        }
    }
}
