using ProjectPatterns.Strategy.Abstract;
using System;

namespace ProjectPatterns.Strategy.Flying
{
    public class FlyWithRocketPropulsion : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Uuuuaaa! Lot z napedem rakietowym!");
        }
    }
}
