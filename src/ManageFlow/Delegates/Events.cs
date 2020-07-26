using System;
using System.Threading;

namespace ManageFlow.Delegates
{
    public class Events
    {
        public delegate void UpdateStatus(string status);

        public event UpdateStatus StatusUpdated;

        public EventHandler<StatusEventArgs> StatusUpdatedAgain;

        public void StartUpdatingStatus()
        {
            while (true)
            {
                var message = $"status, ticks {DateTime.UtcNow.Ticks}";
                StatusUpdatedAgain?.Invoke(this, new StatusEventArgs(message));
                Thread.Sleep(500);
            }
        }
    }

    public class EventSandbox
    {
        public void Test() 
        {
            var events = new Events();
            events.StatusUpdatedAgain += (sender, eventArgs) =>
            {
                Console.WriteLine($"Status : {eventArgs.Status}");
            };
            events.StartUpdatingStatus();
        }

        public void DisplayStatus(string status)
        {
            Console.WriteLine($"2 {status}");
        }
    }

    public class StatusEventArgs : EventArgs
    {
        public string Status { get; set; }

        public StatusEventArgs(string status)
        {
            Status = status;
        }
    }
}