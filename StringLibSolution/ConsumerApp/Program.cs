using System;
using StringExtensions;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Testing the extension methods
            Console.WriteLine("Hello".StartsWithUpper()); // True
            Console.WriteLine("hello".StartsWithUpper()); // False

            // Keep console open (optional)
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
