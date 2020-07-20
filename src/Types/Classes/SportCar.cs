using System;

namespace Types.Classes
{
    public class SportCar : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a sport car...");
            base.Accelerate();
        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a sport car...");
            Speed += 100;
            Console.WriteLine($"Running at: {Speed} km/h");
        }
    }
}