using designPattern.Prototype;

namespace designPattern.Structural.Proxy
{
  
    public class DocumentReader : IDocumentReader
    {
        private readonly String _document;
        private readonly String _owner;

        private readonly String _role;

        
        public DocumentReader(string document, string owner, string role)
        {
            _document = document;
            _owner = owner;
            _role = role;
        }

        public void Open(User user)
        {
            Console.WriteLine("Loading Document from Database.....");
            Console.WriteLine($"Document Opened {_document}.....");
        }
    }
}