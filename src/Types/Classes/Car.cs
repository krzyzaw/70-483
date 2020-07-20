using System;

namespace Types.Classes
{
    public class Car
    {
        public double Speed { get; protected set; } = 100;

        public double Acceleration { get; protected set; } = 10;

        public void Start()
        {
            Console.WriteLine("Turning on the engine...");
            Console.WriteLine($"Running at: {Speed} km/h");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating...");
            Speed += Acceleration;
            Console.WriteLine($"Running at: {Speed} km/h");
        }
    }
}