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
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed mut be greater than zero.");

            if (IsDead)
                Console.WriteLine($"{BusNumber} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    IsDead = true;

                    throw new BusIsDeadException($"{BusNumber} has overheated!", "You have a lead foot.", DateTime.Now);
                }
                else
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}