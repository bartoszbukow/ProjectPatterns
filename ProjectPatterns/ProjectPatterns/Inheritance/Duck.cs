using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance
{
    public abstract class Duck
    {
        public IFlying flying;
        public IQuacking quacking;

        public Duck()
        {

        }

        public abstract void Display();

        public void InvokeFly()
        {
            flying.Fly();
        }

        public void InvokeQuack()
        {
            quacking.DoQuack();
        }

        public void Swim()
        {
            Console.WriteLine("Wszystkie kaczki plywaja, nawet te sztuczne!");
        }

        public void SetFlying(IFlying flying)
        {
            this.flying = flying;
        }

        public void SetQuacking(IQuacking quacking)
        {
            this.quacking = quacking;
        }
    }
}
