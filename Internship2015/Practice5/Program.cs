using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Program
    {
        private static void Main()
        {

            var printerFunctions = new List<Func<int>>();

            for (int i = 0; i < 10; i++)
            {

                printerFunctions.Add(() => i * 2);

            }

            foreach (var printerFunction in printerFunctions)
            {

                Console.WriteLine(printerFunction());

            }

            Console.ReadLine();

        }
    }
}
