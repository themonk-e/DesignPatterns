namespace designPattern.Behavioural.Command
{
    public interface ISchedulerRemote
    {
        public void AddTask(ICommand task);
        public void RunAll();

        public void UndoLast();

    }
}