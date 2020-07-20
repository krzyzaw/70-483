using System;
using System.Diagnostics;
using Types.Classes;
using Types.DataType;
using Types.Extensions;
using Types.Generic;
using Types.Interfaces;
using Types.ObjectLifeCycle;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DisposableResourceWrapper sw = new DisposableResourceWrapper())
            {
                // bee    
            }

            Console.ReadKey();
        }
    }
}
