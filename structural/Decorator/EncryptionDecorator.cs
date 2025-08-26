namespace designPattern.Structural.Decorator
{
    public class EncryptionStorageDecorator : StorageDecorator
    {
        public readonly IStorage _innerStorageDecorator;
        public EncryptionStorageDecorator(IStorage storage) : base(storage)
        {

        }


        public override void Store(string data)
        {
            Console.WriteLine("Encrypting Data...");
            base.Store(data);

        }

        public override void Retrieve()
        {
            Console.WriteLine("Decrypting Data...");
            base.Retrieve();
        }
    }
}