﻿using System;

namespace Practice2
{
    internal class Program
    {

        private static void Main(string[] args)
        {

            var a = new A();

            a = new B(3);

            a.Method();

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

        public class B : A
        {

            static B()
            {

                Console.WriteLine("Static B.");

            }

            public B()
            {

                Console.WriteLine("B.");

            }

            public B(int m)
            {

                Console.WriteLine("Bm.");

            }

            public override void Method()
            {

                Console.WriteLine("Method B.");

                base.Method();

            }

        }

    }
}
