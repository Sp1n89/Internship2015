using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class A { }

    public class B : A { }

    public class C : A { }

    public class D : A
    {

        public override string ToString()
        {

            var s = "D";

            Console.WriteLine(s);

            return s;

        }

    }

    public class Program
    {

        public static void Main()
        {

            var b = new B();

            Console.WriteLine(b is A);

            var b1 = b as A;

            Console.WriteLine(b1 == null);

            Console.WriteLine(b1.GetType());

            float f = 3.3f;

            int i = (int)f;

            Console.WriteLine(i);

            var s = string.Format("{0}={1}", new A(), new D());

            Console.WriteLine(s);


            Console.ReadLine();
        }

    }
}
