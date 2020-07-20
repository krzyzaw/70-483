using System;

namespace Types.Classes
{
    public class Truck : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a truck...");
            base.Accelerate();
        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a truck...");
            Speed += 30;
            Console.WriteLine($"Running at: {Speed} km/h");
        }
    }
}