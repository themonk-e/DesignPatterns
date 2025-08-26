namespace designPattern.Structural.Decorator
{
    public interface IStorage
    {
        public void Store(string data);
        public void Retrieve();
    }
}