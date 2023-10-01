using YardimMasasi.Core;

namespace YardimMasasi.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = "aAbBcCdDeEfFgGhHaAbBcCdDeEfFgGhH";
            string plainText = "Onur AYKIR";

            var encryptedValue = plainText.EncryptMe(key);

            var decryptedValue = encryptedValue.DecryptMe(key);
            Console.WriteLine(plainText);
            Console.WriteLine("----------------------------");
            Console.WriteLine(encryptedValue);
            Console.WriteLine("----------------------------");
            Console.WriteLine(decryptedValue);
            Console.ReadLine();
        }
    }
}