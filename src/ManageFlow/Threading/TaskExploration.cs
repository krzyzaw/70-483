using System;
using System.Threading;
using System.Threading.Tasks;

namespace ManageFlow.Threading
{
    public class TaskExploration
    {
        public void Test()
        {
            Task task1 = Task.Factory.StartNew(PrintNumbers);
            Task.WaitAll(task1);
            Task task2 = Task.Factory.StartNew(PrintNumbers);
            Task.WaitAll(task2);
            Task task3 = Task.Factory.StartNew(PrintNumbers);
        }

        public static void PrintNumbers()
        {
            // Wyświetl liczby.
            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                Thread.Sleep(100 * r.Next(5));
                Console.Write("{0}, ", i);
            }

            Console.WriteLine();
        }

    }
}