namespace designPattern.Behavioural.State
{
    public class InReview : IDocumentState
    {

        public void Next(DocumentStateContext context)
        {
            context.SetState(new Approved(), context.GetState());
                    Console.WriteLine("Document is submitted for approval");

        }
        public void Prev(DocumentStateContext context)
        {
            context.SetState(context.GetPrevState(), null);
                    Console.WriteLine("Document has been sentback to draft");
        }

        public void Edit(DocumentStateContext context)
        {
            Console.WriteLine("Document cannot be edited.");
        }

        public void Save(DocumentStateContext context)
        {
            Console.WriteLine("Not Applicable.");
        }
    } 
}