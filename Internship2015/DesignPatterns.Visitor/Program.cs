using System;

namespace DesignPatterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            #region Count Visitor
            
            Console.WriteLine("1. Count Visitor");
            var countVisitor = new CountVisitor();
            countVisitor.CountElements(client.ObjectStructure);
            Console.WriteLine("Number of elements is: {0}", countVisitor.Count);
            Console.WriteLine();

            #endregion

            #region Display Names Visitor

            Console.WriteLine("2. Display Names Visitor");
            var displayNameVisitor = new DisplayNameVisitor();
            displayNameVisitor.DisplayElementsNames(client.ObjectStructure);
            Console.WriteLine("Elements are: {0}", displayNameVisitor.Output);
            Console.WriteLine();

            #endregion

            Console.ReadLine();
        }
    }
}
