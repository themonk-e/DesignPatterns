namespace designPattern.Structural.Facade
{
    public class LoselessVideoCompressor:IVideoCompressor
    {
        public void CompressVideo(string file)
        {
            Console.WriteLine("Compressing video without losing quality...");
        }
    }
}