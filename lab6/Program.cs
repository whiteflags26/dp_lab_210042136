using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService emailService = new NotificationService(new EmailNotification());
            emailService.Notify("This is an email notification.");

            NotificationService smsService = new NotificationService(new SMSNotification());
            smsService.Notify("This is an SMS notification.");

            NotificationService postalMailService = new NotificationService(new EpostalMailNotificationAdapter(new EpostalMailNotification(), "123 Main St"));
            postalMailService.Notify("This is a postal mail notification.");
            Console.ReadKey();
        }
    }
}
