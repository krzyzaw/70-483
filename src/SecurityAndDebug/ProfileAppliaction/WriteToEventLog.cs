using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SecurityAndDebug.ProfileAppliaction
{
    public class WriteToEventLog
    {
        public static void Write()
        {
            EventLog testEventLog = new EventLog { Source = "Test" };

            testEventLog.WriteEntry("Testowa wiadomosc");
        }
    }
}