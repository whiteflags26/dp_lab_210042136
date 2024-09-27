using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select encryption algorithm: 1. AES  2. DES  3. Caesar Cipher");
            int choice = int.Parse(Console.ReadLine());

            Encryption encryption = new Encryption();

            switch (choice)
            {
                case 1:
                    encryption.SetEncryptionMethod(new AesEncryptionMethod());
                    break;
                case 2:
                    encryption.SetEncryptionMethod(new DesEncryptionMethod());
                    break;
                case 3:
                    Console.Write("Enter Caesar Cipher shift value: ");
                    int shift = int.Parse(Console.ReadLine());
                    encryption.SetEncryptionMethod(new CaesarCipherMethod(shift));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.Write("Enter the file path: ");
            try
            {
                string filePath = Console.ReadLine();
                //string filePath = "C:\\Users\\mirsa\\Documents\\Lab\\dp_lab_210042136\\Lab3\\IO_Operations\\in.txt";
                string fileContents = File.ReadAllText(filePath);

                Console.WriteLine();
                Console.WriteLine("File Contents:");
                
                Console.WriteLine();
                Console.WriteLine("**********");
                Console.WriteLine(fileContents);
                Console.WriteLine("**********");
                Console.WriteLine();

                Console.ReadKey();

                string encrypted = encryption.Encrypt(fileContents);
                File.WriteAllText(filePath + ".enc", encrypted);
                Console.WriteLine("Encrypted file saved.");
                Console.ReadKey();

                string decrypted = encryption.Decrypt(encrypted);
                File.WriteAllText(filePath + ".dec", decrypted);
                Console.WriteLine("Decrypted file saved for validation.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

           
        }
    }
}
