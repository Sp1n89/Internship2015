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

            Console.WriteLine("ṻ".Equals("ǖ", StringComparison.InvariantCulture));  // True

            Console.WriteLine("ṻ".Equals("ǖ", StringComparison.CurrentCulture));    // True (en-US)

            Console.WriteLine("ṻ".Equals("ǖ"));                                     // False
            
            Console.WriteLine(string.Compare("foo", "FOO", StringComparison.InvariantCultureIgnoreCase)); 
            // 0

            Console.WriteLine(string.Compare("foo", "FOO", StringComparison.CurrentCulture));            
            // -1 (Foo > foo)
            
            Console.WriteLine();

            #endregion

            #region 3. Plugging in CultureInfo object

            Console.WriteLine("Plugging in CultureInfo object");

            const string str1 = "change";
            const string str2 = "dollar";

            var relation = Symbol(String.Compare(str1, str2, false, new CultureInfo("en-US")));
            Console.WriteLine("For en-US: {0} {1} {2}", str1, relation, str2);

            relation = Symbol(String.Compare(str1, str2, false, new CultureInfo("cs-CZ")));
            Console.WriteLine("For cs-CZ: {0} {1} {2}", str1, relation, str2);
            Console.WriteLine();

            #endregion

            #region 4. Print ASCII chars

            Console.WriteLine("ASCII characters");
            for (var i = 0; i < 128; i++)
            {
                Console.WriteLine("{0} - {1}",i, (char)i);
            }
            Console.WriteLine();

            #endregion

            #region 5. Align strings

            Console.WriteLine("Aligning strings");
            const string composite = "Name={0, -20} Credit Limit={1, 15:C}";

            Console.WriteLine(composite, "Marry", 500);
            Console.WriteLine(composite, "Elizabeth", 20000);
            Console.WriteLine();

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

