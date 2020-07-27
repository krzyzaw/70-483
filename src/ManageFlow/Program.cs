using System;
using System.Threading;
using System.Threading.Tasks;
using ManageFlow.Delegates;
using ManageFlow.Exceptions;
using ManageFlow.Methods;
using ManageFlow.Threading;

namespace ManageFlow
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AsyncAwait asyncAwait = new AsyncAwait();
            await asyncAwait.Test();

            Console.ReadLine();
        }
    }
}

