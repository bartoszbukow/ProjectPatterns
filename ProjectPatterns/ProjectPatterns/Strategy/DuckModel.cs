using ProjectPatterns.Strategy.Flying;
using ProjectPatterns.Strategy.Quack;
using System;

namespace ProjectPatterns.Strategy
{
    public class DuckModel : Duck
    {
        public DuckModel()
        {
            flying = new IAmNotFlying();
            quacking = new DoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Jestem modelem kaczki");
        }
    }
}
