using System;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedList = new SortedList();
            sortedList.Add("John Doe");
            sortedList.Add("Tommy Toe");
            sortedList.Add("John Smith");

            sortedList.SetSortStrategy(new BubbleSort());
            sortedList.Sort();

            Console.WriteLine(sortedList);

            Console.ReadLine();
        }
    }
}
