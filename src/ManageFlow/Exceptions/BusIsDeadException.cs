using System;

namespace ManageFlow.Exceptions
{
    public class BusIsDeadException : Exception
    {
        public DateTime ErrorTimeStamp { get; set; }

        public string CauseOfError { get; set; }

        public BusIsDeadException() { }

        // Wyślij komunikat do konstruktora nadrzędnego (Exception).
        public BusIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}