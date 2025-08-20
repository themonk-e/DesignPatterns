namespace designPattern.AbstractFactory
{
    public class WindowsCheckbox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Windows CheckBox Rendered Successfully...");
        }
    }
}