using System;

namespace DesignPatterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Console.WriteLine("Count the elements");
            var visitor = new CountVisitor();
            visitor.CountElements(client.ObjectStructure);
            Console.WriteLine("Number of elements is: {0}", visitor.Count);

            Console.ReadLine();
        }
    }
}
