using System;
using System.IO;

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
                try
                {
                    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                    //... zapisanie wyjątku do pliku
                }
                catch (Exception exception)
                {
                    throw new BusIsDeadException(e.Message, exception);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Tutaj przechwycone zostaną wszystkie wyjątki oprócz
            // CarIsDeadException i ArgumentOutOfRangeException.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}