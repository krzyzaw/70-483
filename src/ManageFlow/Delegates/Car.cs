using System;

namespace ManageFlow.Delegates
{
    public class Car
    {
        private Action<string> _handlers;

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

        public void RegisterWithCarEngine(Action<string> methodToCall)
        {
            _handlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(Action<string> methodToCall)
        {
            _handlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (_handlers != null)
                {
                    _handlers("Samochód niesprawny");
                }
            }
            else
            {
                CurrentSpeed += delta;

                if (10 > (MaxSpeed - CurrentSpeed) && _handlers != null)
                {
                    _handlers("Uważaj, silnik zaraz wybuchnie!");
                }

                if (CurrentSpeed > MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Aktualna prędkość: {CurrentSpeed}");
            }
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Wiadomość z obiektu Car *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("\n***** UWAŻAJ!!! *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }
}