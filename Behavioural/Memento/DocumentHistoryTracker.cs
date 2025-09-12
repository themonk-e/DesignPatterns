namespace designPattern.Behavioural.Memento
{
    public class DocumentHistoryTracker
    {
        private Stack<DocumentEditor.Memento> documentHistory = new Stack<DocumentEditor.Memento>();

        private readonly DocumentEditor _documentEditor;
        public DocumentHistoryTracker(DocumentEditor documentEditor)
        {
            _documentEditor = documentEditor;
        }

        public void Save()
        {
            DocumentEditor.Memento restorePoint = _documentEditor.Save();
            documentHistory.Push(restorePoint);
        }

        public void Undo()
        {

            if (documentHistory.Peek != null)
            {
                _documentEditor.Restore(documentHistory.Pop());
            }
        }

    }
}