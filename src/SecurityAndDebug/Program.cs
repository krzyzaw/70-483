using System;
using SecurityAndDebug.Crypto;
using SecurityAndDebug.ValidTypes;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckSum.ShowCheckSum("Hello world");
            CheckSum.ShowCheckSum("world hello");
            CheckSum.ShowCheckSum("Hmmmm world");
            Console.ReadKey();
        }
    }
}
