namespace designPattern.Behavioural.Command
{
    public class MacroTask : IMacro
    {
        private List<ICommand> _commands = new List<ICommand>();
        private Stack<ICommand> _executedCommands = new Stack<ICommand>();
        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
                _executedCommands.Push(command);
            }
        }

        public void Undo()
        {
              if (_executedCommands.Any())
            {
                _executedCommands.Pop().Undo();
            }
        
        }
    }
    
}