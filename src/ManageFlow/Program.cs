using System;
using ManageFlow.Delegates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            userRepository.First(x => x.Id == 1);

            Console.ReadLine();
        }
    }
}

