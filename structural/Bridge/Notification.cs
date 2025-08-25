namespace designPattern.Structural.Bridge
{
    public abstract class Notification
    {
        public readonly ISenderChannel _senderChannel;
        public Notification(ISenderChannel senderChannel)
        {
            _senderChannel = senderChannel;

        }

        public abstract void SendMessage(string Message);
    }
}