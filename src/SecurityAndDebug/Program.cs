﻿using System;
using System.Diagnostics;
using SecurityAndDebug.ApplicationDeb;
using SecurityAndDebug.Crypto;
using SecurityAndDebug.ValidTypes;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTestInfo();
            DisplayDebugInfo();

            Console.ReadKey();
        }


        [Conditional("TEST")]
        public static void DisplayTestInfo()
        {

        }

        [Conditional("DEBUG")]
        public static void DisplayDebugInfo()
        {

        }
    }
}
