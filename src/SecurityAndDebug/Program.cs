﻿using System;
using SecurityAndDebug.Crypto;
using SecurityAndDebug.ValidTypes;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            RsaExploration.Encrypt();
            Console.ReadKey();
        }
    }
}
