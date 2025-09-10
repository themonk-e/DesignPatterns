using System.Runtime.InteropServices;

namespace designPattern.Behavioural.State
{
    public class DocumentStateContext
    {
        private IDocumentState currentState;
        private IDocumentState prevState;


        public DocumentStateContext()
        {
            currentState = new Draft();
        }

        public void SetState(IDocumentState currDocumentState, IDocumentState prevDocumentState)
        {
            currentState = currDocumentState;
            prevState = prevDocumentState;
        }

        public IDocumentState GetState()
        {
            return currentState;
        }

        public IDocumentState GetPrevState()
        {
            return prevState;
        }
        public void Next()
        {
            currentState.Next(this);
        }

        public void Prev()
        {
            currentState.Prev(this);
        }

        public void Edit()
        {
            currentState.Edit(this);
        }

        public void Save()
        {
            currentState.Save(this);
        }
    }
}