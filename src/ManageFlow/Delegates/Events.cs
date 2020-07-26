using System;
using System.Threading;

namespace ManageFlow.Delegates
{
    public class Events
    {
        public delegate void UpdateStatus(string status);

        public event UpdateStatus StatusUpdated;

        public void StartUpdatingStatus()
        {
            while (true)
            {
                var message = $"status, ticks {DateTime.UtcNow.Ticks}";
                StatusUpdated?.Invoke(message);
                Thread.Sleep(500);
            }
        }
    }

    public class EventSandbox
    {
        public void Test()
        {
            var events = new Events();
            events.StatusUpdated += message => Console.WriteLine(message);
            events.StatusUpdated += DisplayStatus;
            events.StartUpdatingStatus();
        }

        public void DisplayStatus(string status)
        {
            Console.WriteLine($"2 {status}");
        }
    }
}