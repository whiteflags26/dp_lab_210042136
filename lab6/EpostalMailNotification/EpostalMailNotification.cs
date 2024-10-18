using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class EpostalMailNotification
    {
        public void SendPostalMail(string address, string message)
        {
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Sending Message: {message}");
        }
    }
}
