using System;
using System.Collections;

namespace ProjectPatterns.Factory.Abstract
{
    public abstract class Pizza
    {
        public string name;
        public string cake;
        public string sauce;
        public ArrayList toppings = new ArrayList();

        public void Preparation()
        {
            Console.WriteLine($"Przygotowywanie: {name}");
            Console.WriteLine("Wyrabianie ciasta...");
            Console.WriteLine("Dodawanie sosu...");
            Console.WriteLine("Dodatki: ");

            for(int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine($"   {toppings[i]}");
            }
        }

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
