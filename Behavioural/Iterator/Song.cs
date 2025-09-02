namespace designPattern.Behavioural.Iterator
{
    public class Song
    {
        public String Title { get; set; }

        public String Artist { get; set; }

        public int Quality { get; set; }

        public Song(string title, string artist, int quality)
        {
            Title = title;
            Artist = artist;
            Quality = quality;
        }


    }
}