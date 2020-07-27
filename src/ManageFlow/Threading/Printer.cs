using System;
using System.Threading;

namespace ManageFlow.Threading
{
    public class Printer
    {
        private object threadLock = new object();

        public void PrintNumbers()
        {
            lock (threadLock)
            {
                // Wyświetl informacje o wątku.
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                    Thread.CurrentThread.Name);

                // Wyświetl liczby.
                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    // Uśpij wątek na losowy czas.
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0}, ", i);
                }

                Console.WriteLine();
            }
        }
    }
}