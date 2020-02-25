using AbstractFactoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDomain
{
    public class DefaultAbstractFactory : ShapeAbstractFactory
    {
        private readonly IDictionary<string, Shape> shapes = new Dictionary<string, Shape>()
        {
            {  "Circle", new Circle() },
            {  "Square", new Square() },
            {  "Triangle", new Triangle() }
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
