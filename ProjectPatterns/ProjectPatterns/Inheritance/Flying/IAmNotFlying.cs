using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance.Flying
{
    public class IAmNotFlying : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Nie umiem latac!");
        }
    }
}
