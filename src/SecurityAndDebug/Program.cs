using System;
using System.Diagnostics;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("Starting the program");
            Trace.Indent();
            Trace.WriteLine("Inside a function");
            Trace.Indent();
            Trace.WriteLine("Outside a function");

            var iUnitQty = 100;
            Trace.WriteLineIf(iUnitQty > 50, "This message WILL appear");
            Trace.WriteLineIf(iUnitQty < 50, "This message will NOT appear");

            double dUnitCost = 1.03;
            Trace.Assert(dUnitCost > 1, "Message will NOT appear");
            Trace.Assert(dUnitCost < 1, "Message will appear since dUnitcost < 1 is false");

            Console.ReadKey();
        }
    }
}
