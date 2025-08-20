namespace designPattern.AbstractFactory
{
    public interface IGUIFactory
    {
        public IButton CreateButton();
        public ICheckBox CreateCheckBox();
    }
}