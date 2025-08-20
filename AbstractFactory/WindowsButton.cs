namespace designPattern.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button Rendered Successfully...");
        }
    }
}