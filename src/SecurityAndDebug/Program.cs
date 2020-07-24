using System;
using SecurityAndDebug.Crypto;
using SecurityAndDebug.ValidTypes;

namespace SecurityAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            var md5 = HashFunction.CreateMd5("Test");
            Console.WriteLine(md5);

            var sha1 = HashFunction.CreateSha1("Test");
            Console.WriteLine(sha1);

            var bytes = HashFunction.CreateSha2("Test");
            HashFunction.ShowHash(bytes);

            Console.ReadKey();
        }
    }
}
