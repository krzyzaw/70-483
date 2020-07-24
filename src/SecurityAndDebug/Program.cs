using System;
using SecurityAndDebug.ApplicationDeb;
using SecurityAndDebug.Crypto;
using SecurityAndDebug.ValidTypes;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicTrack track = new MusicTrack(artist:"Jan", "Kowalski", 100);

            Console.ReadKey();
        }
    }
}
