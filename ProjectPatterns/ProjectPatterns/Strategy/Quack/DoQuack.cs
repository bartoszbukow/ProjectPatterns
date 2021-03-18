using ProjectPatterns.Strategy.Abstract;
using System;

namespace ProjectPatterns.Strategy.Quack
{
    class DoQuack : IQuacking
    {
        void IQuacking.DoQuack()
        {
            Console.WriteLine("Kwa! Kwa!");
        }
    }
}
