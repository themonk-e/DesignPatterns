namespace designPattern.Behavioural.Iterator
{
    public class Playlist :IIterable
    {
        public List<Song> songs = new List<Song>();

        public void AddSong(Song newSong)
        {
            songs.Add(newSong);
        }

        public IIterator CreateNormalIterator()
        {
            return new NormalIterator(songs);
        }

        public IIterator CreateShuffleIterator()
        {
            return new ShuffleIterator(songs);
        }
    }
}