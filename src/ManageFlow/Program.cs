using System;
using ManageFlow.Delegates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new Events();
            events.StartUpdatingStatus();

            Console.ReadLine();
        }
    }
}

