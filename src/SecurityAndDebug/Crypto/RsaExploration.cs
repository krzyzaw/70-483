using System;
using System.Security.Cryptography;
using System.Text;

namespace SecurityAndDebug.Crypto
{
    public class RsaExploration
    {
        public static void Encrypt()
        {
            string plainText = "This is my super secret data";
            Console.WriteLine($"Plain text: {plainText}");

            ASCIIEncoding converter = new ASCIIEncoding();

            byte[] plaintBytes = converter.GetBytes(plainText);

            DumbBytes("Plain bytes: ", plaintBytes);

            byte[] encryptedBytes, decryptedBytes;
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();

            //get keys out of the encryptor
            string publicKey = rsaEncrypt.ToXmlString(includePrivateParameters: false);
            Console.WriteLine($"Public key: {publicKey}");
            string privateKey = rsaEncrypt.ToXmlString(includePrivateParameters: true);
            Console.WriteLine($"Private key: {privateKey}");

            rsaEncrypt.FromXmlString(privateKey);

            encryptedBytes = rsaEncrypt.Encrypt(plaintBytes, fOAEP: false);
            DumbBytes("Encrypted bytes: ", encryptedBytes);

            RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider();
            rsaDecrypt.FromXmlString(privateKey);

            decryptedBytes = rsaDecrypt.Decrypt(encryptedBytes, fOAEP: false);
            DumbBytes("Decrypted bytes: ", decryptedBytes);
            Console.WriteLine($"Decrypted string: {converter.GetString(decryptedBytes)}");
        }

        static void DumbBytes(string title, byte[] bytes)
        {
            Console.WriteLine();
            Console.Write(title);
            foreach (var b in bytes)
            {
                Console.Write($"{b:X} ");
            }

            Console.WriteLine();
        }
    }
}