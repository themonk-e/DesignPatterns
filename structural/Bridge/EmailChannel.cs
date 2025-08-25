namespace designPattern.Structural.Bridge
{
    public class EmailChannel:ISenderChannel
    {
        public void Send(string Message)
        {
            Console.WriteLine($"Sending message: {Message} via email channel");
        }
    }
}