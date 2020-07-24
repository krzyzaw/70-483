using System;
using System.Diagnostics;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting the program");
            Debug.Indent();
            Debug.WriteLine("Inside a function");
            Debug.Indent();
            Debug.WriteLine("Outside a function");

            var iUnitQty = 100;
            Debug.WriteLineIf(iUnitQty > 50, "This message WILL appear");
            Debug.WriteLineIf(iUnitQty < 50, "This message will NOT appear");

            double dUnitCost = 1.03;
            Debug.Assert(dUnitCost > 1, "Message will NOT appear");
            Debug.Assert(dUnitCost < 1, "Message will appear since dUnitcost < 1 is false");

            Console.ReadKey();
        }
    }
}
