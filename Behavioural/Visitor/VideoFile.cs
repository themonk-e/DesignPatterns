namespace designPattern.Behavioural.Visitor
{
    public class VideoFile:IFile
    {

        public string Framerate;
        public string Resolution;
        public double Length;



        public VideoFile(string framerate, string resolution, double length)
        {
            Framerate = framerate;
            Resolution = resolution;
            Length =length;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}