using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new SocialMediaFacade();

            var notifications = facade.GetAllNotifications();
            Console.WriteLine("All Notifications:");
            foreach (var notification in notifications)
            {
                Console.WriteLine($"{notification.Platform} - {notification.Message} (Read: {notification.IsRead})");
            }
            Console.WriteLine();


            facade.MarkNotificationAsRead("Twitter", "1");
            Console.WriteLine();
            
            facade.MarkNotificationAsUnread("Facebook", "1");
            Console.WriteLine();

            facade.DeleteNotification("Twitter", "2");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
