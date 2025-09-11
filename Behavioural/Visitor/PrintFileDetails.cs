namespace designPattern.Behavioural.Visitor
{
    public class PrintFileDetails : IVisitor
    {
        public void Visit(TextFile file)
        {
            Console.WriteLine($" Word Count:{file.WordCount} \n Encoding:{file.WordCount}");
        }

        public void Visit(VideoFile file)
        {
            Console.WriteLine($" Resolution:{file.Resolution} \n FrameRate:{file.Framerate}");
        }

        public void Visit(ImageFile file)
        {
            Console.WriteLine($" Resolution:{file.Resolution} \n Color Scheme:{file.ColorScheme}");
        }
        

    }
}