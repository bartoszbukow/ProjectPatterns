using ProjectPatterns.Strategy.Abstract;
using System;

namespace ProjectPatterns.Strategy.Quack
{
    public class DoNotQuack : IQuacking
    {
        public void DoQuack()
        {
            Console.WriteLine("<<<CISZA>>>");
        }
    }
}
