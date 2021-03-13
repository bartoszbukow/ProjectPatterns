using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance.Quack
{
    class DoQuack : IQuacking
    {
        void IQuacking.DoQuack()
        {
            Console.WriteLine("Kwa! Kwa!");
        }
    }
}
