using System;
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
            Enumerator enumerator = new Enumerator(10);

            foreach (var VARIABLE in enumerator)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadKey();
        }
    }
}
