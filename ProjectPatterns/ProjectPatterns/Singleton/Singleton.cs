
namespace ProjectPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton uniqueInstance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock (uniqueInstance)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new Singleton();
                }

                return uniqueInstance;
            }
        }
    }
}
