namespace designPattern.Behavioural.Command
{
    public class TaskScheduler : ISchedulerRemote
    {
        private List<ICommand> _tasks = new List<ICommand>();
        private Stack<ICommand> _executedTasks = new Stack<ICommand>();
        public void AddTask(ICommand task)
        {
            _tasks.Add(task);

        }
        public void RunAll()
        {
            foreach (var task in _tasks)
            {
                task.Execute();
                _executedTasks.Push(task);
            }
        }

        public void UndoLast()
        {
            if (_executedTasks.Any())
            {
                _executedTasks.Pop().Undo();
            }
        }


    }
}