using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance.Flying
{
    public class IFryBecauseIHaveWings : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("O rany! Latam!");
        }
    }
}
