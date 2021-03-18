using ProjectPatterns.Strategy.Abstract;
using System;

namespace ProjectPatterns.Strategy.Flying
{
    public class IAmNotFlying : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Nie umiem latac!");
        }
    }
}
