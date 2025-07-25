namespace designPattern.Factory
{
    public class PushNotifcationService : INotificationService
    {
        void INotificationService.SendNotification(string notificationMessage)
        {
            Console.WriteLine(notificationMessage);
        }
    }
}