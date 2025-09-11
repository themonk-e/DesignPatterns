namespace designPattern.Behavioural.State
{
    public class Publish : IDocumentState
    {

        public void Next(DocumentStateContext context)
        {
            Console.WriteLine("The document has been already published.No further steps.");

        }
        public void Prev(DocumentStateContext context)
        {
            Console.WriteLine("The document has been already published.No further steps.");
        }

        public void Edit(DocumentStateContext context)
        {
           Console.WriteLine("Not applicable");
        }

        public void Save(DocumentStateContext context)
        {
          Console.WriteLine("Not applicable");
        }
    } 
}