using System;

namespace Adapter
{
    internal class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new();
        public void SendNotification(int userId, Notification notification)
        {
            string userPhoneNumber = userId.ToString("D9");

           _smsSender.Send(userPhoneNumber, $"Title: {notification.Title}\n{notification.Body}");
        }
    }
}