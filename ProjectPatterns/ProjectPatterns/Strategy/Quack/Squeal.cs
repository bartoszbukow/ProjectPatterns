using ProjectPatterns.Strategy.Abstract;
using System;

namespace ProjectPatterns.Strategy.Quack
{
    public class Squeal : IQuacking
    {
        public void DoQuack()
        {
            Console.WriteLine("Piszcze!");
        }
    }
}
