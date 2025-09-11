namespace designPattern.Behavioural.Visitor
{
    public class CalculateSizeOnDisk : IVisitor
    {
        public void Visit(TextFile file)
        {
            Console.WriteLine($" SizeOnDisk:{file.WordCount*100} KB");
        }

        public void Visit(VideoFile file)
        {
            Console.WriteLine($"SizeOnDisk:{file.Length*10} MB");
        }

        public void Visit(ImageFile file)
        {
            Console.WriteLine($"SizeOnDisk:{file.DPI*10} KB");
        }
        

    }
}