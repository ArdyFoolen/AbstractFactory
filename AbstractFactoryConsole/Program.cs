using AbstractFactoryContracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeAbstractFactorySection configSection = ShapeAbstractFactorySection.Settings;
            ShapeAbstractFactory shapeAbstractFactory = CreateAbstractFactory(configSection);

            string[] shapeNames = shapeAbstractFactory.GetShapeNames();

            foreach (string shapeName in shapeNames)
            {
                Shape shape = shapeAbstractFactory.Make(shapeName);
                shape.Draw();
            }

            Console.Write("Press any key to continue. . .");
            Console.ReadKey();
        }

        private static ShapeAbstractFactory CreateAbstractFactory(ShapeAbstractFactorySection configSection)
        {
            Assembly assembly = Assembly.Load(configSection.AbstractFactoryDll);
            Type type = assembly.GetType(configSection.AbstractFactoryName);
            ShapeAbstractFactory shapeAbstractFactory = (ShapeAbstractFactory)Activator.CreateInstance(type);
            return shapeAbstractFactory;
        }
    }
}
