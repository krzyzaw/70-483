using System;

namespace ManageFlow.Exceptions
{
    public class BusIsDeadException : Exception
    {
        public DateTime ErrorTimeStamp { get; set; }

        public string CauseOfError { get; set; }

        public BusIsDeadException() { }

        public BusIsDeadException(string message, Exception inner) : base(message, inner)
        {
        }

        // Wyślij komunikat do konstruktora klasy bazowej (Exception).
        public BusIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}