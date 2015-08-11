using System;

namespace Practice3
{
    internal class Program
    {

        private static void Main(string[] args)
        {

            var a1 = new A(3);

            var a2 = new A(3);

            Console.WriteLine(a1 == a2);

            Console.WriteLine(a1.GetType());

            int b1 = 3;

            int b2 = 3;

            Console.WriteLine(b1 == b2);

            Console.WriteLine(b1.GetType());

            var c1 = new { A = 3, B = 3 };

            var c2 = new { A = 3, B = 3 };

            Console.WriteLine(c1 == c2);

            Console.WriteLine(c1.GetType());


            Console.ReadLine();
        }

        public class A
        {

            static A()
            {

                Console.WriteLine("Static A.");

            }

            public A()
            {

                Console.WriteLine("A.");

            }

            public A(int m)
            {

                Console.WriteLine("Am.");

            }

            public virtual void Method()
            {

                Console.WriteLine("Method A.");

            }

        }

        
    }
}
