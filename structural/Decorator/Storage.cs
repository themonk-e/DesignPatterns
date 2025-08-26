namespace designPattern.Structural.Decorator
{
    public class Storage : IStorage
    {
        public readonly string _fileName;
        public string data;
        public Storage(string fileName)
        {
            _fileName = fileName;
        }
        public void Store(string data)
        {
            Console.WriteLine("Storing Data...");
            this.data = data;
        }

        public void Retrieve()
        {
            Console.WriteLine("Retrieving Data...");
            Console.WriteLine($"Retrieved:{data}");
        }
    }
}