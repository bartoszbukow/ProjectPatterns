using ProjectPatterns.Factory.Abstract.Ingredients;
using System;
using System.Collections.Generic;

namespace ProjectPatterns.Factory.Abstract
{
    public abstract class Pizza
    {
        public string name;
        public ICake cake;
        public ISauce sauce;
        public List<IVegetables> Vegetables;
        public ICheese Cheese;
        public IPepperoni Pepperoni;
        public IMussels Mussels;

        public abstract void Preparation();

        public virtual void Baking()
        {
            Console.WriteLine("Pieczenie: 25 minut w temperaturze 350 stopni Celsjusza");
        }

        public virtual void Slicing()
        {
            Console.WriteLine("Krojenie pizzy na 8 kawalkow");
        }

        public virtual void Packing()
        {
            Console.WriteLine("Pakowanie pizza w oficjalne pudelko naszej sieci Pizzerii.");
        }

        public string GetName()
        {
            return name;
        }
    }
}
