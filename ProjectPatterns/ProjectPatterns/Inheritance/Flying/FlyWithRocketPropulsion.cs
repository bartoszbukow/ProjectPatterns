using ProjectPatterns.Inheritance.Abstract;
using System;

namespace ProjectPatterns.Inheritance.Flying
{
    public class FlyWithRocketPropulsion : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Uuuuaaa! Lot z napedem rakietowym!");
        }
    }
}
