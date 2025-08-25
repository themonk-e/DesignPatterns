namespace designPattern.Structural.Adapter
{
    public class DocumentViwerApp{

        private IDocumentViewer DocumentViewer;
        public DocumentViwerApp(IDocumentViewer documentViewer)
        {
            DocumentViewer = documentViewer;
        }
        public void DisplayDoc(string fileName)
        {
            DocumentViewer.Display(fileName);
        }
    } 
}