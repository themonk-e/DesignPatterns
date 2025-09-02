namespace designPattern.Behavioural.Iterator
{
    public class ShuffleIterator : IIterator
    {
        private List<Song> songList = new List<Song>();

        public ShuffleIterator(List<Song> songs)
        {

            songList = new List<Song>();
        }

        int position;
        public bool HasNext()
        {
            if (songList.Count() > 0) return true;

            return false;
        }

        public Song Next()
        {
            Random rand = new Random();

            int index = rand.Next(songList.Count);
            Song picked = songList[index];
            songList.RemoveAt(index);
            return picked;
        }

    }
}