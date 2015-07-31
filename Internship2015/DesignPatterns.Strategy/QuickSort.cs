using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Quick sorted.");
        }
    }
}