namespace designPattern.Behavioural.State
{
    public class Draft : IDocumentState
    {

        public void Next(DocumentStateContext context)
        {
            context.SetState(new InReview(), context.GetState());
            Console.WriteLine("Document is submitted for review");

        }
        public void Prev(DocumentStateContext context)
        {
            Console.WriteLine("This is the initial state");
            return;
        }

        public void Edit(DocumentStateContext context)
        {
            Console.WriteLine("Document is being Edited..");
        }

        public void Save(DocumentStateContext context)
        {
            Console.WriteLine("Document has been saved.");
        }
    } 
}