namespace designPattern.Behavioural.Command
{
    public interface IMacro: ICommand
    {
        public void AddCommand(ICommand command);
    }
}