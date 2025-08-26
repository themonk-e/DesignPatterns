namespace designPattern.Structural.Decorator
{
    public abstract class StorageDecorator : IStorage
    {
        public readonly IStorage _innerStorageDecorator;
        public StorageDecorator(IStorage storage)
        {
            _innerStorageDecorator = storage;
        }


        public virtual void Store(string data)
        {
           
            _innerStorageDecorator.Store(data);
            
        }

        public virtual void Retrieve()
        {
            _innerStorageDecorator.Retrieve();
        }
    }
}