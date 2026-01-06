//---- Przykład: Adapter konwertujący interfejs (przykład z użyciem: Adapter obiektowy)
// 

/*
Załóżmy, że mamy istniejący system do wysyłania powiadomień do użytkownika.
System ten używa interfejsu INotificationSender. W naszym systemie mamy już powiadomienia e-mail i PUSH, ale chemy dodać jeszcze notyfikacje SMS – zewnętrzny serwis.
Chcemy skorzystać z już istniejących rozwiązań i zintegrować nowy rodzaj powiadomień, tak aby był kompatybilny z naszym systemem. W tym celu użyjemy adaptera.
UML naszego przykładu:
*/



using ConsoleApp1;

class Program
{
    private static void Main(string[] args)
    {
        INotificationSender notificationSender = new EmailSender();
        notificationSender.SendNotification(1, new Notification() { Title = "TITLE", Body = "BODY" });

        INotificationSender pushNotificationSender = new PushSender();
        pushNotificationSender.SendNotification(2, new Notification() { Title = "TITLE 2", Body = "BODY 2" });

        INotificationSender smsNotificationSender = new SmsSenderAdapter();
        smsNotificationSender.SendNotification(2, new Notification() { Title = "TITLE 3", Body = "BODY 3" });


        //INotificationSender smsNotificationSenderTest = new SmsSender();
        //smsNotificationSenderTest

        //SmsSender smsNotificationSenderTest = new SmsSender();
        //smsNotificationSenderTest.SendSms("example", "Title 4, Body 4");

    }
}