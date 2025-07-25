namespace designPattern.Factory
{
    public class EmailService : INotificationService
    {
        void INotificationService.SendNotification(string notificationMessage)
        {
            Console.WriteLine(notificationMessage);
        }
    }
}