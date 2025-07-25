namespace designPattern.Factory
{
    public class SMSService : INotificationService
    {
        void INotificationService.SendNotification(string notificationMessage)
        {
            Console.WriteLine(notificationMessage);
        }
    }
}