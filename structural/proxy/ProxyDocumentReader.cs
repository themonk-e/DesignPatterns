using System.Data;
using designPattern.Prototype;

namespace designPattern.Structural.Proxy
{
  
    public class ProxyDocumentReader : IDocumentReader
    {
        private readonly String _document;
        private readonly String _owner;

        private Dictionary<String, Byte[]> _cacheMemory = new Dictionary<string, byte[]>();

        private readonly List<String> _accessList = new List<string>{ "admin", "editor", "manager" };
        private readonly String _role;

        public ProxyDocumentReader(string document, string owner, string role)
        {
            _document = document;
            _owner = owner;
            _role = role;
        }
        public void Open(User user)
        {
            if (_accessList.Contains(user.getUserRole()))
            {
                if (_cacheMemory.ContainsKey(_document))
                {

                    Console.WriteLine("Loading Document from Cache.....");
                    Console.WriteLine($"Document Opened {_document}.....");
                }
                else
                {
                _cacheMemory.Add(_document, new byte[100]); 
                DocumentReader documentReader = new DocumentReader(_document, _owner, _role);
                documentReader.Open(user);

                }
              
            }
            else
            {
                 Console.WriteLine("Access Denied.....");
            }
           
          
        }
    }
}