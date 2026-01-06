using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmailSender : INotificationSender
    {
        public void SendNotification(int userID, Notification notification)
        {
            Console.WriteLine($"Sending email notificationto: {userID}, title: {notification.Title}.");
        }
    }
}
