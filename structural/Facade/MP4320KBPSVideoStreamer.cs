namespace designPattern.Structural.Facade
{
    public class MP4320KBPSVideoStreamer:IVideoStremingService
    {
        public void UploadFile(string file)
        {
            Console.WriteLine("uploading...");
        }
        public void StreamVideo(string file)
        {
            Console.WriteLine("Streaming video...");
        }
        
    }
}