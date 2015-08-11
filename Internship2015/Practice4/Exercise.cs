using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Exercise
    {

        public void Test()
        {

            IA<A1> i1 = null;

            IA<A2> i2 = null;

            IA<A3> i3 = null;

            IA<A4> i4 = null;

        }

        public class A1
        {

        }

        public class A2 : A1
        {

        }

        public class A3 : A2
        {

            public A3(int m)
            {

            }

        }

        public class A4
        {

        }

        private interface IA<T> where T : A1, new()
        {

        }

    }
}
