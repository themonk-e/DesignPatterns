namespace designPattern.Behavioural.State
{
    public class Approved : IDocumentState
    {

        public void Next(DocumentStateContext context)
        {
            context.SetState(new Publish(), context.GetState());

        }
        public void Prev(DocumentStateContext context)
        {
            Console.WriteLine("Cannot go to review state.");
        }

        public void Edit(DocumentStateContext context)
        {
            Console.WriteLine("Cannot edit document as it is already approved.");
        }

        public void Save(DocumentStateContext context)
        {
            Console.WriteLine("Not applicable.");
        }
    } 
}