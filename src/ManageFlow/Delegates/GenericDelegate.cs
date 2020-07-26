using System;
using System.Threading;

namespace ManageFlow.Delegates
{
    public class GenericDelegate
    {
        public delegate void Write<T>(T message);

        public static void TestGenericDelegate()
        {
            Write<string> strTarget = new Write<string>(Writer);
            Writer("test");

            CheckTemperature(TooHighAlert, TempIsOptimal);
        }

        public static void Writer(string arg)
        {
            Console.WriteLine($"{arg}");
        }

        public static void CheckTemperature(Write<string> optimal, Write<string> tooHigh)
        {
            var temperature = 50;
            var random = new Random();

            while (true)
            {
                var change = random.Next(-5, 5);
                temperature += change;

                if (temperature <= 50)
                {
                    optimal("Optimal");
                }
                else
                {
                    tooHigh("Too high");
                }

                Thread.Sleep(500);
            }
        }

        public static void TooHighAlert(string alertMessage)
        {
            Console.WriteLine(alertMessage);
        }

        public static void TempIsOptimal(string optimalMessage)
        {
            Console.WriteLine(optimalMessage);
        }
    }
}