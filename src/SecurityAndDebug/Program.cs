﻿using System;
using SecurityAndDebug.ApplicationDebug;
using SecurityAndDebug.Crypto;
using SecurityAndDebug.ValidTypes;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicTrack.DebugMode = true;
            MusicTrack track = new MusicTrack(artist:"Jan", "Kowalski", 100);

            Console.ReadKey();
        }
    }
}
