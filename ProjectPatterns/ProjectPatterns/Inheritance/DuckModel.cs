using ProjectPatterns.Inheritance.Flying;
using ProjectPatterns.Inheritance.Quack;
using System;

namespace ProjectPatterns.Inheritance
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
