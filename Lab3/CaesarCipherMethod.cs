using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class CaesarCipherMethod : IEncryptionMethod
    {
        private readonly int shift;

        public CaesarCipherMethod(int shift)
        {
            this.shift = shift;
        }

        public string Encrypt(string plainText)
        {
            return ShiftText(plainText, shift);
        }

        public string Decrypt(string cipherText)
        {
            return ShiftText(cipherText, -shift);
        }

        private string ShiftText(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    result.Append((char)((c + shift - d + 26) % 26 + d));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }

}
