namespace designPattern.Structural.Proxy
{
    public class User
    {
        private readonly string _name;
        private readonly string _role;

        public User(string name, string role)
        {
            _name = name;
            _role = role;
        }

        public string getUserRole()
        {
            return _role;
        }
    }
}