using lab7.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Adapter
{
    public class TwitterAdapter : ISocialMediaAdapter
    {
        private readonly TwitterApi _twitterApi = new TwitterApi();

        public string GetPlatform()
        {
            return "Twitter";
        }

        public List<Notification> GetNotifications()
        {
            return _twitterApi.FetchNotifications();
        }

        public void MarkAsRead(string notificationId)
        {
            _twitterApi.MarkNotificationAsRead(notificationId);
        }

        public void MarkAsUnread(string notificationId)
        {
            _twitterApi.MarkNotificationAsUnread(notificationId);
        }

        public void DeleteNotification(string notificationId)
        {
            _twitterApi.DeleteNotification(notificationId);
        }
    }
}
