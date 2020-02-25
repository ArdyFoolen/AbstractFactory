using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDomain
{
    public class ShapeNameInvalidException : Exception
    {
        private string shapeName;
        public ShapeNameInvalidException(string shapeName)
        {
            this.shapeName = shapeName;
        }

        public override string Message => $"{base.Message}\nShapeName {this.shapeName} is invalid";
    }
}
