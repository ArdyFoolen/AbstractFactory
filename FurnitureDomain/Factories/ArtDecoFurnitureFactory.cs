using FurnitureDomain.ArtDeco;
using FurnitureDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Factories
{
    public class ArtDecoFurnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
