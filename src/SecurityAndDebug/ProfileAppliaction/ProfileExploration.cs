using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using SecurityAndDebug.Crypto;

namespace SecurityAndDebug.ProfileAppliaction
{
    public class ProfileExploration
    {
        public static void Test()
        {
            var encryptTimer = Stopwatch.StartNew();
            for (var i = 0; i < 100; i++)
            {
                AesExploration.Encrypt();
            }
            encryptTimer.Stop();

            var sumTimer = Stopwatch.StartNew();
            for (var i = 0; i < 100; i++)
            {
                CheckSum.ShowCheckSum("TEST");
            }
            sumTimer.Stop();


            Console.WriteLine($"Aes timer: {encryptTimer.ElapsedMilliseconds}");
            Console.WriteLine($"Sum timer: {sumTimer.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}