namespace designPattern.Structural.Adapter
{
    public class WordReaderAdapter : IDocumentViewer
    {

        WordReaderAPI readerAPI = new WordReaderAPI();
        public void Display(string fileName)
        {
            readerAPI.showDocument(fileName);
        }
    
    } 
}