namespace designPattern.Behavioural.Iterator
{
    public interface IIterable
    {
        public IIterator CreateNormalIterator();

       public IIterator CreateShuffleIterator();

    }
}