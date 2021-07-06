using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Generics
{
    public static class ExtensionMethods
    {
        public static IEnumerable<int> Odds<T>(IEnumerable<int> number)
        {
            return number.Where(n => n % 2 != 0);
        }
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> collection)
        {
            return collection.OrderBy(x => x);
        }
    }
}
