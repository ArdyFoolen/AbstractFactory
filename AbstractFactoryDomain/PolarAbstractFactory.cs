using AbstractFactoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDomain
{
    public class PolarAbstractFactory : ShapeAbstractFactory
    {
        private readonly IDictionary<string, Shape> shapes = new Dictionary<string, Shape>()
        {
            {  "Square", new PolarSquare() },
            {  "Circle", new PolarCircle() }
        };

        public Shape Make(string shapeName)
        {
            Shape shape = shapes.ContainsKey(shapeName)
                ? shapes[shapeName]
                : throw new ShapeNameInvalidException(shapeName);

            return shape;
        }

        public string[] GetShapeNames()
        {
            return shapes.Keys.ToArray();
        }

    }
}
