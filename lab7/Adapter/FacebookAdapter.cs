using lab7.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Adapter
{
    public class FacebookAdapter : ISocialMediaAdapter
    {
        private readonly FacebookApi _facebookApi = new FacebookApi();

        public string GetPlatform()
        {
            return "Facebook";
        }

        public List<Notification> GetNotifications()
        {
            return _facebookApi.GetNotifications();
        }

        public void MarkAsRead(string notificationId)
        {
            _facebookApi.MarkAsRead(notificationId);
        }

        public void MarkAsUnread(string notificationId)
        {
            _facebookApi.MarkAsUnread(notificationId);
        }

        public void DeleteNotification(string notificationId)
        {
            _facebookApi.RemoveNotification(notificationId);
        }
    }

}
