using System;
using System.Threading;
using System.Threading.Tasks;

namespace ManageFlow.Threading
{
    public class TaskExploration
    {
        public static void Test()
        {
            // tworzenie nowego wątku
            var thread = new Thread(start =>
            {
                // zadanie do wykonania
            });
            thread.Start();

            // tworzenie nowego zadania
            Task.Factory.StartNew(() =>
            {
                // zadanie do wykonania
            });
        }
    }
}