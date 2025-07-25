
namespace designPattern.Factory
{
    public  class NotificationFactory
    {


        public  INotificationService CreateNotification(Channel channel)
        {
            if (channel.Equals(Channel.email))
            {
                return new EmailService();
            }
            else if (channel.Equals(Channel.sms))
            {
                return new SMSService();
            }

            return new PushNotifcationService();
        }
    }
}