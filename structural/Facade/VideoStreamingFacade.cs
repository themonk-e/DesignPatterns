namespace designPattern.Structural.Facade
{
    public class VideoStreamingFacade
    {
        private readonly IVideoCompressor _compressor;
        private readonly IVideoFileReader _videoFileReader;
        private readonly IVideoStremingService _videoStremingService;

        private readonly IAudioProcessor _audioProcessor;
        public VideoStreamingFacade(IVideoCompressor videoCompressor,
        IAudioProcessor audioProcessor,
        IVideoStremingService videoStremingService,
        IVideoFileReader videoFileReader)
        {
            _compressor = videoCompressor;
            _audioProcessor = audioProcessor;
            _videoFileReader = videoFileReader;
            _videoStremingService = videoStremingService;
        }


        public void StreamVideo(string file)
        {
            _videoFileReader.ReadVideoFile(file);
            _audioProcessor.ProcessAudio(file);
            _compressor.CompressVideo(file);
            _videoStremingService.StreamVideo(file);
        }
        
    }
}