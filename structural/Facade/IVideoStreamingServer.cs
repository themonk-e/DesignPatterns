namespace designPattern.Structural.Facade
{
    public interface IVideoStremingService
    {
        public void UploadFile(string file);
        public void StreamVideo(string file);
        
    }
}