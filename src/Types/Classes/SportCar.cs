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
    }
}