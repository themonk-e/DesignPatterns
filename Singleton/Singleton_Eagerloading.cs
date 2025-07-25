namespace designPatterns
{
    public class Singleton
    {
        private static readonly Singleton INSTANCE = new Singleton();


        private Singleton() { }

        public static Singleton getInstance()
        {
            return INSTANCE;
        }
    }
}

//Thread safe
