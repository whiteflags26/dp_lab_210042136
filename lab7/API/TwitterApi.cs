using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.API
{
    public class TwitterApi
    {
        public List<Notification> FetchNotifications()
        {
            return new List<Notification>
            {
                new Notification { Id = "1", Platform = "Twitter", Message = "New tweet from user", IsRead = false },
                new Notification { Id = "2", Platform = "Twitter", Message = "Someone liked your tweet", IsRead = false }
            };
        }

        public void MarkNotificationAsRead(string notificationId)
        {
            Console.WriteLine($"Twitter API: Marked {notificationId} as read.");
        }

        public void MarkNotificationAsUnread(string notificationId)
        {
            Console.WriteLine($"Twitter API: Marked {notificationId} as unread.");
        }

        public void DeleteNotification(string notificationId)
        {
            Console.WriteLine($"Twitter API: Deleted {notificationId}.");
        }
    }
}
