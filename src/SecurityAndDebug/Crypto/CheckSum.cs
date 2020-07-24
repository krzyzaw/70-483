using System;

namespace SecurityAndDebug.Crypto
{
    public class CheckSum
    {
        public static int CalculateCheckSum(string source)
        {
            int total = 0;
            foreach (var ch in source)
                total += ch;

            return total;
        }

        public static void ShowCheckSum(string source)
        {
            Console.WriteLine($"Checksum for {source} is {CalculateCheckSum(source)}");
        }
    }
}