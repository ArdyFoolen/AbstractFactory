using FurnitureDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDomain.Factories
{
    public class FurnitureNullObject : IChair, ICoffeeTable, ISofa
    {
        public void Show()
        {
        }
    }
}
