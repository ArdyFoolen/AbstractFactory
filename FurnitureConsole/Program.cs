using FurnitureConsole.Extensions;
using FurnitureDomain.Factories;
using System;
using System.Linq;

namespace FurnitureConsole
{
    // See Independent deployment: FurnitureFactory
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available Factory families:");
            FurnitureFactory.AvailableFactories().ForEach(f => Console.WriteLine($"\t{f}"));
            Console.WriteLine();

            Console.WriteLine("Show Product All Families:");
            FurnitureFactory.AvailableFactories().ForEach(f => Show(f));
        }

        private static void Show(FurnitureFactory factory)
        {
            factory.CreateChair().Show();
            factory.CreateCoffeeTable().Show();
            factory.CreateSofa().Show();
        }

        private static void Show(string family)
        {
            Console.WriteLine($"\tFamily: {family}");
            Show(FurnitureFactory.CreateFactory(family));
        }
    }
}
