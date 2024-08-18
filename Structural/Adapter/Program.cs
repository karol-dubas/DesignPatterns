using System;

namespace Adapter
{
    class Program
    {
        // Adapter umożliwia współpracę dwóm klasom o niekompatybilnych interfejsach.
        // Przekształca interfejs jednej klasy na interfejs drugiej.

        // Chcę do aplikacji, która wysyła powiadomienia email i push dodać wysyłanie powiadomień sms,
        // z osobnej zewnątrznej biblioteki, która nie jest kompatybilna z moimi interfejsami.

        static void Main(string[] args)
        {
            Notification notification = new Notification()
            {
                Title = "Test title",
                Body = "Test body message."
            };

            INotificationSender emailSender = new EmailSender();
            emailSender.SendNotification(1, notification);

            INotificationSender smsSender = new SmsSenderAdapter();
            smsSender.SendNotification(2, notification);
        }
    }
}
