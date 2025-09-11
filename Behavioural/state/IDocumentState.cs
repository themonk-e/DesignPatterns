namespace designPattern.Behavioural.State
{
    public interface IDocumentState
    {
        public void Next(DocumentStateContext context);
        public void Prev(DocumentStateContext context);
        public void Edit(DocumentStateContext context);

        public void Save(DocumentStateContext context);
    } 
}