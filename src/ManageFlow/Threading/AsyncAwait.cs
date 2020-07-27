using System;
using System.Threading;
using System.Threading.Tasks;

namespace ManageFlow.Threading
{
    public class AsyncAwait
    {
        public async Task Test()
        {
            await PrintNumbersAsync();
            await PrintNumbersAsync();
            await PrintNumbersAsync();
            await PrintNumbersAsync();
        }

        public async Task PrintNumbersAsync()
        {
            await Task.Run(() =>
            {
                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(100 * r.Next(5));
                    Console.Write("{0}, ", i);
                }

                Console.WriteLine();
            });
        }
    }
}