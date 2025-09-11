namespace designPattern.Behavioural.Visitor
{
    public class ImageFile:IFile
    {

        public string ColorScheme;
        public string Resolution;

        public int DPI;

        public ImageFile(string colorScheme, string resolution, int dpi)
        {
            ColorScheme = colorScheme;
            Resolution = resolution;
            DPI = dpi;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}