using ProjectPatterns.Inheritance.Flying;
using ProjectPatterns.Inheritance.Quack;
using System;

namespace ProjectPatterns.Inheritance
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
