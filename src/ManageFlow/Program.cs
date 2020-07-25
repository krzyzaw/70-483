using System;
using System.Security.Cryptography.X509Certificates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod.Add(1, 2, out int ans);
            Console.WriteLine(ans);

            TestMethod.ReturnManyValue(out var i, out var str, out var b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            
            Console.ReadKey();
        }
    }
}
