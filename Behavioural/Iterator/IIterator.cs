namespace designPattern.Behavioural.Iterator
{
    public interface IIterator
    {
        public bool HasNext();

        public Song Next();
    
    }
}