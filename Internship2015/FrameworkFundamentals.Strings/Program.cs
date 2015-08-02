using System;
using System.Globalization;

namespace FrameworkFundamentals.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. string.Compare methods examples 

            Console.WriteLine("string.Compare methods examples");
            Console.WriteLine(string.Compare("Boston", "Austin", StringComparison.InvariantCulture));  // 1
            Console.WriteLine(string.Compare("Boston", "Boston", StringComparison.InvariantCulture));  // 0
            Console.WriteLine(string.Compare("Boston", "Chicago", StringComparison.InvariantCulture)); // −1
            Console.WriteLine();

            #endregion
            
            #region 2. string.Compare ignore case

            Console.WriteLine("string.Compare ignore case");
            Console.WriteLine(string.Compare("foo", "FOO", StringComparison.InvariantCultureIgnoreCase)); // 0
            Console.WriteLine();

            #endregion

            #region 3. plugging in CultureInfo object

            Console.WriteLine("plugging in CultureInfo object");

            const string str1 = "change";
            const string str2 = "dollar";

            var relation = Symbol(String.Compare(str1, str2, false, new CultureInfo("en-US")));
            Console.WriteLine("For en-US: {0} {1} {2}", str1, relation, str2);

            relation = Symbol(String.Compare(str1, str2, false, new CultureInfo("cs-CZ")));
            Console.WriteLine("For cs-CZ: {0} {1} {2}", str1, relation, str2);

            #endregion

            Console.ReadLine();
        }

        private static String Symbol(int r)
        {
            var s = "=";
            if (r < 0) s = "<";
            else if (r > 0) s = ">";
            return s;
        }
    }
}
