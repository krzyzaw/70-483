using System;
using ManageFlow.Delegates;
using ManageFlow.Exceptions;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exceptions.Exceptions.Test();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            Console.ReadLine();
        }
    }
}

