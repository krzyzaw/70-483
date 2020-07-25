using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SecurityAndDebug.Crypto
{
    public class Cert
    {
        public static void Test()
        {
            
            ASCIIEncoding converter = new ASCIIEncoding();

            X509Store store = new X509Store("demoCertStore", StoreLocation.CurrentUser);

            store.Open(OpenFlags.ReadOnly);

            X509Certificate2 certificate = store.Certificates[0];

            


            RSACryptoServiceProvider decryptProvider = certificate.PublicKey.Key as RSACryptoServiceProvider;
            RSACryptoServiceProvider encryptProvider = certificate.PrivateKey as RSACryptoServiceProvider;


            string messageToSign = "This is the message I want to sign";
            Console.WriteLine($"Message {messageToSign}");

            byte[] messageToSignBytes = converter.GetBytes(messageToSign);
            DumbBytes("Message to sign in bytes: ", messageToSignBytes);

            //need to calculate hash for this message - this will go into the
            //signature and be used to verify the message
            HashAlgorithm hasher = new SHA1Managed();
            byte[] hash = hasher.ComputeHash(messageToSignBytes);
            DumbBytes("Hash for message: ", hash);

            //sign the hash to create signature
            byte[] signature = encryptProvider.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
            DumbBytes("Signature: ", messageToSignBytes);

           // RSACryptoServiceProvider decryptProvider = certificate.PublicKey.Key as RSACryptoServiceProvider;
            bool validSignature = decryptProvider.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
            Console.WriteLine($"Correct signature validated OK: {validSignature}");

            signature[0] = 99;
            bool invalidSignature = decryptProvider.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
            Console.WriteLine($"Correct signature validated OK: {invalidSignature}");
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