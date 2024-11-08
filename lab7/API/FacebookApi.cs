using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.API
{
    public class FacebookApi
    {
        public List<Notification> GetNotifications()
        {
            return new List<Notification>
            {
                new Notification { Id = "1", Platform = "Facebook", Message = "New friend request", IsRead = false },
                new Notification { Id = "2", Platform = "Facebook", Message = "Someone liked your post", IsRead = false }
            };
        }

        public void MarkAsRead(string notificationId)
        {
            Console.WriteLine($"Facebook API: Marked {notificationId} as read.");
        }

        public void MarkAsUnread(string notificationId)
        {
            Console.WriteLine($"Facebook API: Marked {notificationId} as unread.");
        }

        public void RemoveNotification(string notificationId)
        {
            Console.WriteLine($"Facebook API: Removed {notificationId}.");
        }
    }
}
