using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    public class A
    {

    }

    public class B : A
    {

    }

    public class C : A
    {

    }

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

            var c = new C();

            Console.WriteLine(c is A);

            var c1 = c as A;

            Console.WriteLine(c1 == null);

            Console.WriteLine(c1.GetType());

            double d = 3.3d;

            int i = (int)d;

            Console.WriteLine(i);

            A a = new D();

            var s = string.Format("{0}={1}", new A(), a);

            Console.WriteLine(s);


            Console.ReadLine();
        }

    }
}
