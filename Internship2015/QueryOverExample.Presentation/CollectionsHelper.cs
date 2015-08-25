using System;
using System.Collections.Generic;

namespace QueryOverExample.Presentation
{
    public static class CollectionsHelper
    {
        public static void PrintToConsole<T>(this IEnumerable<T> list) where T : class
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}