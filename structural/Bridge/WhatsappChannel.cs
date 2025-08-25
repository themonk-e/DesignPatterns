namespace designPattern.Structural.Bridge
{
    public class WhatsappChannel:ISenderChannel
    {
        public void Send(string Message)
        {
            Console.WriteLine($"Sending message: {Message} via Whatsapp channel");
        }
    }
}