using System;
using System.Security.Cryptography.X509Certificates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;
            average = TestMethod.CalculateAverage("test", 4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine($"Average of data is: {average}");

            double[] data = { 4.0, 3.2, 5.7 };
            average = TestMethod.CalculateAverage("test", data);
            Console.WriteLine($"Average of data is: {average}");

            Console.ReadKey();
        }
    }
}
