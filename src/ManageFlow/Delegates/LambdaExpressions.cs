using System;
using System.Threading;

namespace ManageFlow.Delegates
{
    public class LambdaExpressions
    {
        public static void Test()
        {
            Action writer = () => Console.WriteLine("Writing...");
            Action<string, int> advancedWriter = (message, number) =>
                Console.WriteLine($"{message}, {number}");

            Func<int, int, int> adder = (x, y) => x + y;

            writer();
            advancedWriter("Hello", 5);
            var sum = adder(1, 2);
            advancedWriter("sum", sum);

            Action<int, string> logger = (temperature, message) =>
            {
                Console.WriteLine($"Temperature is at: {temperature} C. {message}");
            };

            CheckTemperature(t => logger(t, "To low!"), t => logger(t, "Optimal!"), t => logger(t, "Too high"));
        }

        public static void CheckTemperature(Action<int> tooLow, Action<int> optimal, Action<int> tooHigh)
        {
            var temperature = 10;
            var random = new Random();

            while (true)
            {
                var change = random.Next(-5, 5);
                temperature += change;

                if (temperature <= 0)
                {
                    tooLow(temperature);
                }
                else if (temperature > 0 && temperature <= 10)
                {
                    optimal(temperature);
                }
                else
                {
                    tooHigh(temperature);
                }

                Thread.Sleep(500);
            }
        }

        public static void OptimalAlert(int change)
        {
            Console.WriteLine($"Temperature is optimal (change by {change})");
        }

        public static void TooHighAlert(int change)
        {
            Console.WriteLine($"Temperature is too high (change by {change})");
        }

        public static void TooLowAlert(int change)
        {
            Console.WriteLine($"Temperature is too low (change by {change})");
        }
    }
}