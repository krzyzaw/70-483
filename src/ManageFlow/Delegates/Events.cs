using System;

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
                StatusUpdated(message);
            }
        }
    }
}