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
            var handler = new Car.CarEngineHandler(Car.OnCarEngineEvent);
            var handler2 = new Car.CarEngineHandler(Car.OnCarEngineEvent2);

            car.RegisterWithCarEngine(handler);
            car.RegisterWithCarEngine(handler2);

            Console.WriteLine("***** Speeding up *****");

            // Zwiększ prędkość (w ten sposób zostaną wyzwolone zdarzenia).
            for (int i = 0; i < 6; i++)
                car.Accelerate(20);

            car.UnRegisterWithCarEngine(handler2);

            for (int i = 0; i < 6; i++)
                car.Accelerate(20);

            Console.ReadLine();
        }
    }
}

