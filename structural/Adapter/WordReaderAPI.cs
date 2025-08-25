namespace designPattern.Structural.Adapter
{
    public class WordReaderAPI{
        public void showDocument(string fileName)
        {
            Console.WriteLine($"showing document {fileName}");
        }
    } 
}