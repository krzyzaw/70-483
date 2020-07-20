using System;
using System.Diagnostics;
using Types.Classes;
using Types.DataType;
using Types.Extensions;
using Types.Generic;
using Types.Interfaces;
using Types.Lazy;
using Types.ObjectLifeCycle;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer.Test();
            CustomerLazyLoading.Test();
            Console.ReadKey();
        }
    }
}
