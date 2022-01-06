using FurnitureDomain.Interfaces;
using FurnitureDomain.Victorian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Factories
{
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
