using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Encryption
    {
        private IEncryptionMethod encryptionMethod;

        public void SetEncryptionMethod(IEncryptionMethod encryptionMethod)
        {
            this.encryptionMethod = encryptionMethod;
        }

        public string Encrypt(string inputString)
        {
            return encryptionMethod.Encrypt(inputString);
        }

        public string Decrypt(string encryptedString)
        {
            return encryptionMethod.Decrypt(encryptedString);
        }
    }

}
