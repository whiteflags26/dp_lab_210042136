using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class NotificationService
    {
        private readonly INotification _notification;

        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message)
        {
            _notification.Send(message);
        }
    }
}
