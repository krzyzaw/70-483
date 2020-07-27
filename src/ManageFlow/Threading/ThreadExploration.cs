using System;
using System.Threading;

namespace ManageFlow.Threading
{
    public class ThreadExploration
    {
        public static void TestMethod()
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");
            Printer p = new Printer();

            // Utwórz 10 wątków, które wskazują na tę samą metodę tego samego obiektu.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(p.PrintNumbers)
                {
                    Name = $"Worker thread #{i}"
                };
            }

            // Rozpocznij każdy z nich.
            foreach (Thread t in threads)
                t.Start();

            Console.ReadLine();
        }
    }
}