using System;
using System.Diagnostics;
using Types.Classes;
using Types.DataType;
using Types.Extensions;
using Types.Generic;
using Types.Interfaces;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportHeader();
            ReportHeaderDebug();
            Console.ReadKey();
        }

        [Conditional("PROD")]
        static void ReportHeader()
        {
            Console.WriteLine("Trace");
        }

        [Conditional("RELEASE")]
        static void ReportHeaderDebug()
        {
            Console.WriteLine("Debug");
        }
    }
}
