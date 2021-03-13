using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance.Quack
{
    public class DoNotQuack : IQuacking
    {
        public void DoQuack()
        {
            Console.WriteLine("<<<CISZA>>>");
        }
    }
}
