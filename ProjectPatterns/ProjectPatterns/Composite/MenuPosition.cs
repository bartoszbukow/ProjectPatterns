using ProjectPatterns.Composite.Abstract;
using System;

namespace ProjectPatterns.Composite
{
    public class MenuPosition : MenuComponent
    {
        readonly string name;
        readonly string description;
        readonly bool vegetarian;
        readonly decimal price;

        public MenuPosition(string name, string description, bool vegetarian, decimal price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override decimal GetPrice()
        {
            return price;
        }

        public override bool IsVegetarian()
        {
            return vegetarian;
        }

        public override void Print()
        {
            Console.WriteLine("   " + GetName());
            if (IsVegetarian()) Console.WriteLine("(w)");
            Console.WriteLine(", ", GetPrice());
            Console.WriteLine("        -- ", GetDescription());
        }
    }
}
