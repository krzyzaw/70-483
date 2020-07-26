using System;

namespace ManageFlow.Delegates
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);

        public  CarEngineHandler Handler = OnCarEngineEvent;

        public int CurrentSpeed { get; set; }

        public int MaxSpeed { get; set; }

        public string Brand { get; set; }

        private bool carIsDead;

        public Car(int currentSpeed, int maxSpeed, string brand)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            Brand = brand;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Handler != null)
                {
                    Handler("Samochód niesprawny");
                }
            }
            else
            {
                CurrentSpeed += delta;

                if (10 > (MaxSpeed - CurrentSpeed) && Handler != null)
                {
                    Handler("Uważaj, silnik zaraz wybuchnie!");
                }

                if (CurrentSpeed > MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Current speed: {CurrentSpeed}");
            }
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }
}