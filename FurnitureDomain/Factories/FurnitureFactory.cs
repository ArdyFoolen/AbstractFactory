using FurnitureDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Factories
{
    // Independent deployment
    // (Un)comment below 2 lines
    // Build only FurnitureDomain project
    // In Cmd go to ~\AbstractFactory\FurnitureConsole\Deploy
    // Run FurnitureConsole
    public enum FurnitureFamilies
    {
        ArtDeco,
        //Modern,
        Victorian
    }

    public abstract class FurnitureFactory
    {
        public virtual IChair CreateChair()
        {
            return new FurnitureNullObject();
        }

        public virtual ICoffeeTable CreateCoffeeTable()
        {
            return new FurnitureNullObject();
        }

        public virtual ISofa CreateSofa()
        {
            return new FurnitureNullObject();
        }

        public static string[] AvailableFactories()
        {
            return Enum.GetNames(typeof(FurnitureFamilies));
        }

        public static FurnitureFactory CreateFactory(string factory)
        {
            if (!Enum.TryParse(factory, out FurnitureFamilies factoryFamily))
                return null;

            switch (factoryFamily)
            {
                case FurnitureFamilies.ArtDeco: return new ArtDecoFurnitureFactory();
                //case FurnitureFamilies.Modern: return new ModernFurnitureFactory();
                case FurnitureFamilies.Victorian: return new VictorianFurnitureFactory();
                default: return null;
            }
        }
    }
}
