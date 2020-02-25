using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryContracts
{
    public interface ShapeAbstractFactory
    {
        Shape Make(string shapeName);
        string[] GetShapeNames();
    }
}
