using System;
using System.Threading;

namespace ManageFlow.Threading
{
    public class Printer
    {
        public void PrintNumbers()
        {
            // Wyświetl informacje o wątku.
            Console.WriteLine("-> {0} is executing PrintNumbers()",
                Thread.CurrentThread.Name);

            // Wyświetl liczby.
            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}