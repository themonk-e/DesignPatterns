namespace designPattern.Structural.Facade
{
    public class MP4VideoReader:IVideoFileReader
    {
        public void ReadVideoFile(string file)
        {
            Console.WriteLine("Reading an MP4 video file");
        }
    }
}