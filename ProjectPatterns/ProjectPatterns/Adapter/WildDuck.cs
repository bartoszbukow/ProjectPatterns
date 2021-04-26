using ProjectPatterns.Adapter.Abstract;
using System;

namespace ProjectPatterns.Adapter
{
    public class WildDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("O rany! Latam!");
        }

        public void Quack()
        {
            Console.WriteLine("Kwa! Kwa!");
        }
    }
}
