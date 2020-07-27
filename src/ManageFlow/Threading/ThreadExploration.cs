using System;
using System.Threading;
using ManageFlow.Methods;

namespace ManageFlow.Threading
{
    public class ThreadExploration
    {
        public static void TestMethod()
        {
            Console.WriteLine("***** Background Threads *****\n");
            Printer p = new Printer();
            Thread bgroundThread = new Thread(new ThreadStart(p.PrintNumbers));

            // Teraz to jest wątek drugoplanowy.
            bgroundThread.IsBackground = true;
            bgroundThread.Start();
        }
    }
}