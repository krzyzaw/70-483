using System;
using System.IO;
using System.Security.Cryptography;

namespace SecurityAndDebug.Crypto
{
    public class AesExploration
    {
        public static void Encrypt()
        {
            string plainText = "This is my super secret data";

            byte[] cipherText, key, initializationVector;

            using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                initializationVector = aes.IV;

                ICryptoTransform encryptor = aes.CreateEncryptor();

                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    using (CryptoStream encryptCryptoStream = new CryptoStream(encryptMemoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(encryptCryptoStream))
                        {
                            swEncrypt.Write(plainText);
                        }

                        cipherText = encryptMemoryStream.ToArray();
                    }
                }
            }

            Console.WriteLine($"String to encrypt: {plainText}");
            DumbBytes("Key: ", key);
            DumbBytes("Initialization Vector: ", initializationVector);
            DumbBytes("Encrypted: ", cipherText);

            Decrypt(key, initializationVector, cipherText);

            Console.ReadKey();
        }

        public static void Decrypt(byte[] key, byte[] initializationVector, byte[] cipherText)
        {
            var decryptedText = string.Empty;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = initializationVector;

                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream decrypStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream decryptCryptoStream = new CryptoStream(decrypStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(decryptCryptoStream))
                        {
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            Console.WriteLine(decryptedText);
        }

        static void DumbBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (var b in bytes)
            {
                Console.Write($"{b:X} ");
            }

            Console.WriteLine();
        }
    }
}