using System;
using System.Security.Cryptography.X509Certificates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine($"Before: {str1}, {str2}");
            TestMethod.SwapStrings(ref str1, ref str2);
            Console.WriteLine($"After: {str1}, {str2}");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
