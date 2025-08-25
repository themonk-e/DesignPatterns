namespace designPattern.Structural.Bridge
{
    public class AlertNotification:Notification
    {

        public AlertNotification(ISenderChannel senderChannel):base(senderChannel)
        {
        }

        public override void SendMessage(string Message)
        {
            Console.WriteLine("NotificationType:Alert");
            _senderChannel.Send(Message);
        }
    }
}