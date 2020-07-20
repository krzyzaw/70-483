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
    }
}