using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ManageFlow.Threading
{
    public class Plinq
    {
        public void Test()
        {
            Task.Factory.StartNew(() =>
            {
                ProcessIntData();
            });
        }

        private void ProcessIntData()
        {
            Stopwatch counter = new Stopwatch();
            counter.Start();

            // Uzyskaj bardzo dużą tablicę wartości całkowitoliczbowych.
            int[] source = Enumerable.Range(1, 10000000).ToArray();
            
            // Znajdź liczby spełniające warunek num % 3 == 0,
            // zwróć w kolejności malejącej.
            int[] modThreeIsZero = (from num in source.AsParallel()
                where num % 3 == 0
                orderby num descending
                select num).ToArray();

            Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");

            counter.Stop();
            Console.WriteLine(counter.ElapsedMilliseconds);
        }
    }
}