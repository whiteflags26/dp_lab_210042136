using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class EpostalMailNotificationAdapter : INotification
    {
        private readonly EpostalMailNotification _ePostalMailNotification;
        private readonly string _name;
        private readonly string _address;
        private readonly string _postalCode;

        public EpostalMailNotificationAdapter(EpostalMailNotification ePostalMailNotification, string address)
        {
            _ePostalMailNotification = ePostalMailNotification;
            _address = address;
        }

        public void Send(string message)
        {
            _ePostalMailNotification.SendPostalMail(_address, message);
        }
    }
}
