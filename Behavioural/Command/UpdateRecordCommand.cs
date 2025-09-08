namespace designPattern.Behavioural.Command
{
    public class UpdateRecordCommand : ICommand
    {
        private string _employeeID;
        private string _message;
        public UpdateRecordCommand(string employeeID, string message)
        {
            _employeeID = employeeID;
            _message = message;

        }

        public void Execute()
        {
            Console.WriteLine($"Updating record for {_employeeID} ....");
            Console.WriteLine("Record updated.");
        }
        public void Undo()
        {
            Console.WriteLine("Undoing record update...");
        }

    }
    
     public class SendEmailCommand: ICommand
    {
        private string _mailID;
        private string _message;
        public SendEmailCommand(string mailID, string message)
        {
            _mailID = mailID;
            _message = message;

        }

        public void Execute()
        {
            Console.WriteLine($"Sending email to {_mailID} ....");
            Console.WriteLine("Email Sent.");
        }
        public void Undo()
        {
            Console.WriteLine("Undoing email...");
        }

    }
}