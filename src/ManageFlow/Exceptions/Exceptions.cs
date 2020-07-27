using System;
using System.Runtime.CompilerServices;

namespace ManageFlow.Exceptions
{
    public class Exceptions
    {
        public static void Test()
        {
            Bus myBus = new Bus("70a", 40);
            myBus.TurnOnRadio();

            for (int i = 0; i < 10; i++)
            {
                myBus.Accelerate(10);
            }
        }
    }
}