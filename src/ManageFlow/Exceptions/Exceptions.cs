using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ManageFlow.Exceptions
{
    public class Exceptions
    {
        public static void Test()
        {
            Bus myBus = new Bus("70a", 40);
            myBus.TurnOnRadio();

            try
            {
                for (int i = 0; i < 10; i++)
                    myBus.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine($"Method: {e.TargetSite},\nMessage: {e.Message},\nSource: {e.Source}");
            }
        }
    }
}