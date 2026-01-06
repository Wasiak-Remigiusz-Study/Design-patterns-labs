using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new SmsSender();
        public void SendNotification(int userID, Notification notification)
        {
            string userPhoneNumber = "example"; // na  podstawie userID np. poszukac numer telefonu w bazie danych
            _smsSender.SendSms(userPhoneNumber, $"{notification.Title} \n {notification.Body}");
        }
    }
}
