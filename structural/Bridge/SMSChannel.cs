namespace designPattern.Structural.Bridge
{
    public class SMSChannel:ISenderChannel
    {
        public void Send(string Message)
        {
            Console.WriteLine($"Sending message: {Message} via SMS channel");
        }
    }
}