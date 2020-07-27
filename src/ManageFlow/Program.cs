using System;
using System.Threading;
using ManageFlow.Delegates;
using ManageFlow.Exceptions;
using ManageFlow.Methods;
using ManageFlow.Threading;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Plinq plinq = new Plinq();
            plinq.Test();

           Console.ReadLine();
        }
    }
}

