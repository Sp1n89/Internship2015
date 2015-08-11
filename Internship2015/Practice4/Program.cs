using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Test
    {

        private static void Main()
        {

            var printerActions = new List<Action>();

            for (int i = 0; i < 10; i++)
            {

                printerActions.Add(() => Console.WriteLine(i));

            }

            foreach (Action printerAction in printerActions)
            {

                printerAction();

            }

            Console.ReadLine();

        }

    }
}
