using System;
using ManageFlow.Delegates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventSandbox = new EventSandbox();
            eventSandbox.Test();

            Console.ReadLine();
        }
    }
}

