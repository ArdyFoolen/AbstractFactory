using FurnitureDomain.Interfaces;
using FurnitureDomain.Modern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Factories
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
