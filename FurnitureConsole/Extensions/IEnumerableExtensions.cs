using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureConsole.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            foreach (T t in array)
                action(t);
        }
    }
}
