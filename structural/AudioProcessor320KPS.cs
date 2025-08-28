namespace designPattern.Structural.Facade
{
    public class AudioProcessor320KBPS:IAudioProcessor
    {
        public void ProcessAudio(string file)
        {
            Console.WriteLine("Processing 320KBPS audio..");
        }
    }
}