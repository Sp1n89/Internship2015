using System;
using DesignPatterns.Visitor.Example3;

namespace DesignPatterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            #region Count Visitor
            
            //Console.WriteLine("1. Count Visitor");
            //var countVisitor = new CountVisitor();
            //countVisitor.CountElements(client.ObjectStructure);
            //Console.WriteLine("Number of elements is: {0}", countVisitor.Count);
            //Console.WriteLine();

            #endregion

            #region Display Names Visitor

            //Console.WriteLine("2. Display Names Visitor");
            //var displayNameVisitor = new DisplayNameVisitor();
            //displayNameVisitor.DisplayElementsNames(client.ObjectStructure);
            //Console.WriteLine("Elements are: {0}", displayNameVisitor.Output);
            //Console.WriteLine();

            #endregion

            var book = new Book("C# Design Patterns", 25);
            var fruit = new Fruit("Oranges", 6, 3);
            var priceVisitor = new PriceCalculatorVisitor();
            book.Accept(priceVisitor);
            fruit.Accept(priceVisitor);

            Console.WriteLine(priceVisitor.Total);
            // 25 + (6*3)

            Console.ReadLine();
        }
    }
}
