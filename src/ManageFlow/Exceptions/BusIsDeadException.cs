using System;

namespace ManageFlow.Exceptions
{
    public class BusIsDeadException : Exception
    {
        private string messageDetails = string.Empty;

        public DateTime ErrorTimeStamp { get; set; }

        public string CauseOfError { get; set; }

        public BusIsDeadException() { }

        public BusIsDeadException(string message,
            string cause, DateTime time)
        {
            messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // Nadpisz właściwość Exception.Message
        public override string Message => $"Bus Error Message: {messageDetails}";
    }
}