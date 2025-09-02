namespace designPattern.Behavioural.Iterator
{
    public class NormalIterator: IIterator
    {
        private List<Song> songList = new List<Song>();

        public NormalIterator(List<Song> songs)
        {
            position = 0;
            songList = songs;
        }

        int position;
        public bool HasNext()
        {
            if (position < songList.Count()) return true;

            return false;
        }

        public Song Next()
        {
            return songList[position++];
        }
    
    }
}