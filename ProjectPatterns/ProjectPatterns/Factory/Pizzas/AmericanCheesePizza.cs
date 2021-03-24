using ProjectPatterns.Factory.Abstract;
using System;

namespace ProjectPatterns.Factory.Pizzas
{
    public class AmericanCheesePizza : Pizza
    {
        public AmericanCheesePizza()
        {
            name = "Amerykanska Pizza Serowa";
        }

        public override void Baking()
        {
            Console.WriteLine("Krojenie pizzy na kwadratowe kawalki");
        }

        public override void Preparation()
        {
            throw new NotImplementedException();
        }
    }
}
