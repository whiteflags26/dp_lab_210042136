using lab7.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class SocialMediaFacade
    {
        private readonly List<ISocialMediaAdapter> _adapters;

        public SocialMediaFacade()
        {
            _adapters = new List<ISocialMediaAdapter>
            {
                new TwitterAdapter(),
                new FacebookAdapter()
            };
        }

        public List<Notification> GetAllNotifications()
        {
            var notifications = new List<Notification>();
            foreach (var adapter in _adapters)
            {
                notifications.AddRange(adapter.GetNotifications());
            }
            return notifications;
        }

        public void MarkNotificationAsRead(string platform, string notificationId)
        {
            foreach (var adapter in _adapters)
            {
                if (adapter.GetPlatform() == platform)
                {
                    adapter.MarkAsRead(notificationId);
                }
            }
        }

        public void MarkNotificationAsUnread(string platform, string notificationId)
        {
            foreach (var adapter in _adapters)
            {
                if (adapter.GetPlatform() == platform)
                {
                    adapter.MarkAsUnread(notificationId);
                }
            }
        }

        public void DeleteNotification(string platform, string notificationId)
        {
            foreach (var adapter in _adapters)
            {
                if (adapter.GetPlatform() == platform)
                {
                    adapter.DeleteNotification(notificationId);
                }
            }
        }
    }

}
