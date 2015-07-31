using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            bool swapped;
            do
            {
                swapped = false;

                for (var i = 0; i < list.Count - 1; i++)
                {
                    var result = String.Compare(list[i], list[i + 1], StringComparison.InvariantCulture);
                    if (result > 0)
                    {
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);

            Console.WriteLine("Bubble sorted.");
        }
    }
}