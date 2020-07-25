using System;
using System.Security.Cryptography;
using System.Text;

namespace SecurityAndDebug.Crypto
{
    public class HashFunction
    {
        public static string CreateMd5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (var t in hashBytes)
                {
                    sb.Append(t.ToString());
                }

                return sb.ToString();
            }
        }

        public static string CreateSha1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (var b in hash)
                {
                    sb.Append(b.ToString());
                }
                return sb.ToString();
            }
        }

        public static byte[] CreateSha2(string value)
        {
            byte[] encryptedBytes;

            using (var hashTool = new SHA256Managed())
            {
                encryptedBytes = hashTool.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(value)));
                hashTool.Clear();
            }

            return encryptedBytes;
        }

        public static void ShowHash(byte[] hash)
        {
            foreach (var b in hash)
            {
                Console.Write($"{b:X}");
            }

            Console.WriteLine();
        }
    }
}