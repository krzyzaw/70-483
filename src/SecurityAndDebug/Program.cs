using System;
using System.Diagnostics;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceListener consoleListener = new ConsoleTraceListener();
            Trace.Listeners.Add(consoleListener);

            Trace.TraceInformation("Info message");
            Trace.TraceWarning("Warning message");
            Trace.TraceError("ErrorMessage");

            Console.ReadKey();
        }
    }
}
