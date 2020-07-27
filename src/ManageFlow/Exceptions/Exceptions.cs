using System;

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
            catch (BusIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
        }
    }
}