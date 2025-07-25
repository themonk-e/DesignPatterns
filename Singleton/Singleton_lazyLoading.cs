using System.Security.Cryptography;

namespace designPatterns
{
    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        public static SingletonLazy INSTANCE => _instance.Value;

        public static int Count = 0;

        public int incrementCount()
        {
            Count++;
            return Count;
        }

    }
}

//Thread safe
