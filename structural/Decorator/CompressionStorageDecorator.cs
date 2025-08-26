namespace designPattern.Structural.Decorator
{
    public class CompressionStorageDecorator : StorageDecorator
    {

        public CompressionStorageDecorator(IStorage storage) : base(storage)
        {

        }


        public override void Store(string data)
        {
            Console.WriteLine("Compressing Data...");
            base.Store(data);

        }

        public override void Retrieve()
        {
            Console.WriteLine("Decompressing Data...");
            base.Retrieve();
        }
    }
}