namespace designPattern.Structural.Bridge
{
    public class ReminderNotification:Notification
    {

        public ReminderNotification(ISenderChannel senderChannel):base(senderChannel)
        {
        }

        public override void SendMessage(string Message)
        {
            Console.WriteLine("NotificationType:Reminder");
            _senderChannel.Send(Message);
        }
    }
}