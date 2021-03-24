
namespace ProjectPatterns.Singleton
{
    public class Singleton3
    {
        private volatile static Singleton3 uniqueInstance;

        private Singleton3() { }

        public static Singleton3 GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (uniqueInstance)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton3();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}