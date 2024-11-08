using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Adapter
{
    public interface ISocialMediaAdapter
    {
        List<Notification> GetNotifications();
        string GetPlatform();
        void MarkAsRead(string notificationId);
        void MarkAsUnread(string notificationId);
        void DeleteNotification(string notificationId);
    }
}
