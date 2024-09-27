using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DesEncryptionMethod : IEncryptionMethod
    {
        private readonly byte[] Key = Encoding.UTF8.GetBytes("8bytekey");
        private readonly byte[] IV = Encoding.UTF8.GetBytes("8byteivv");

        public string Encrypt(string plainText)
        {
            using (DES des = DES.Create())
            {
                des.Key = Key;
                des.IV = IV;

                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);
                byte[] encrypted = PerformCryptography(plainText, encryptor);
                return Convert.ToBase64String(encrypted);
            }
        }

        public string Decrypt(string cipherText)
        {
            using (DES des = DES.Create())
            {
                des.Key = Key;
                des.IV = IV;

                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);
                byte[] decrypted = PerformCryptography(Convert.FromBase64String(cipherText), decryptor);
                return Encoding.UTF8.GetString(decrypted);
            }
        }

        private byte[] PerformCryptography(string text, ICryptoTransform transform)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(text);
            return PerformCryptography(inputBytes, transform);
        }

        private byte[] PerformCryptography(byte[] inputBytes, ICryptoTransform transform)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    cs.Write(inputBytes, 0, inputBytes.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }
    }

}
