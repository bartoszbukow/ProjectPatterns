using ProjectPatterns.Strategy.Flying;
using ProjectPatterns.Strategy.Quack;
using System;

namespace ProjectPatterns.Strategy
{
    public class WildDuck : Duck
    {
        public WildDuck()
        {
            quacking = new DoQuack();
            flying = new IFryBecauseIHaveWings();
        }

        public override void Display()
        {
            Console.WriteLine("Jestem prawdziwa kaczka dziwaczka!");
        }
    }
}
