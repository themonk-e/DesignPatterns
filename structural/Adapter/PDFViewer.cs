namespace designPattern.Structural.Adapter
{
    public class PDFViewer : IDocumentViewer
    {
        public void Display(string fileName)
        {
            Console.WriteLine($"Displaying document {fileName}");
        }
    } 
}