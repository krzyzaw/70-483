using System;
using ManageFlow.Delegates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(brand:"Ford",maxSpeed: 100, currentSpeed: 10);
            // Zwiększ prędkość (w ten sposób zostaną wyzwolone zdarzenia).
            Console.WriteLine("***** Speeding up *****");
            
            for (int i = 0; i < 6; i++)
                car.Accelerate(20);

            Console.ReadLine();
        }

        
    }
}

