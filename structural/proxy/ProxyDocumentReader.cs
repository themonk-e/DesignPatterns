using System.Data;
using designPattern.Prototype;

namespace designPattern.Structural.Proxy
{
  
    public class ProxyDocumentReader : IDocumentReader
    {
        private readonly String _document;
        private readonly String _owner;

        private readonly String _role;

        public ProxyDocumentReader(string document, string owner, string role)
        {
            _document = document;
            _owner = owner;
            _role = role;
        }
        public void Open(User user)
        {
            if (user.getUserRole().Equals("admin") || user.getUserRole().Equals("editor"))
            {
                DocumentReader documentReader = new DocumentReader(_document, _owner, _role);
                documentReader.Open(user);

            }
            else
            {
                 Console.WriteLine("Access Denied.....");
            }
           
          
        }
    }
}