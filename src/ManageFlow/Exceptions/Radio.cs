using System;

namespace ManageFlow.Exceptions
{
    public class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "The radio is playing..." : "Quiet...");
        }
    }
}