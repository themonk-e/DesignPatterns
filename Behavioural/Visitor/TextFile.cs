namespace designPattern.Behavioural.Visitor
{
    public class TextFile:IFile
    {
        public int WordCount;
        public string EncodingFormat;

        
        

        public TextFile(int wordCount, string format)
        {
            WordCount = wordCount;
            EncodingFormat = format;

        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}