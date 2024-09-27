using System.IO;
using System;
using System.Security.Cryptography;
using System.Text;
using Lab3;

public class AesEncryptionMethod : IEncryptionMethod
{
    private readonly byte[] Key;
    private readonly byte[] IV;

    public AesEncryptionMethod()
    {
        Key = Encoding.UTF8.GetBytes("1234567890abcdef"); 
        IV = Encoding.UTF8.GetBytes("InitializationVe"); 
    }

    public string Encrypt(string inputString)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            byte[] encrypted = PerformCryptography(inputString, encryptor);
            return Convert.ToBase64String(encrypted);
        }
    }

    public string Decrypt(string encryptedString)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            byte[] decrypted = PerformCryptography(Convert.FromBase64String(encryptedString), decryptor);
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
