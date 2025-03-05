using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCryptoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "1234567890123456"; // 16 byte key for AES-128
            string iv = "abcdefabcdefabcd"; // 16 byte IV

            Encryptor encryptor = new Encryptor(key, iv);

            string plainText = "This is my library.";
            string cipherText = encryptor.Encrypt(plainText);
            string decryptedText = encryptor.Decrypt(cipherText);

            Console.WriteLine("Plaintext: " + plainText);
            Console.WriteLine("Ciphertext: " + cipherText);
            Console.WriteLine("Decrypted: " + decryptedText);
        }
    }
}
