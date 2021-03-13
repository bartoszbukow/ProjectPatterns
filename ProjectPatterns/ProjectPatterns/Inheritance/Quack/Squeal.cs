using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance.Quack
{
    public class Squeal : IQuacking
    {
        public void DoQuack()
        {
            Console.WriteLine("Piszcze!");
        }
    }
}
