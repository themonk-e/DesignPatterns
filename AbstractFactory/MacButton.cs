namespace designPattern.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Mac Button Rendered Successfully...");
        }
    }
}