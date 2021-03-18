using ProjectPatterns.Strategy.Abstract;
using System;

namespace ProjectPatterns.Strategy.Flying
{
    public class IFryBecauseIHaveWings : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("O rany! Latam!");
        }
    }
}
