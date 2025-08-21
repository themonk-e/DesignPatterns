namespace designPattern.Prototype
{
    public interface IDocument : ICloneable
    {

        public void createDocument(string Title, string Author, string Content, Formatting DocFormatting);
        public void printDocument();
        public new object Clone();
    }
}