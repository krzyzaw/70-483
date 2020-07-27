using System;

namespace ManageFlow.Exceptions
{
    public class Bus
    {
        public const int MaxSpeed = 80;

        public string BusNumber { get; set; }

        public int Speed { get; set; }

        public Radio Radio { get; set; }

        public bool IsDead { get; set; }

        public int CurrentSpeed { get; set; }

        public Bus(string busNumber, int currentSpeed)
        {
            BusNumber = busNumber;
            CurrentSpeed = currentSpeed;
            Radio = new Radio();
        }

        public void TurnOnRadio()
        {
            Radio.TurnOn(true);
        }

        public void Accelerate(int delta)
        {
            if (IsDead)
                Console.WriteLine($"{BusNumber} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine($"{BusNumber} has overheated!");
                    CurrentSpeed = 0;
                    IsDead = true;
                }
                else
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}