using System;
using System.IO;
using System.Text;

namespace FrameworkFundamentals.GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var fs = new FileStream("myFile.txt", FileMode.Open);

            const string str = "Hello world!";
            var bytes = Encoding.ASCII.GetBytes(str);
            Console.WriteLine(bytes.Length);
            var bytesCount = Encoding.ASCII.GetByteCount(str);
            Console.WriteLine(bytesCount);

            Console.ReadLine();
        }
    }
}
