using ProjectPatterns.Factory.Abstract;
using System;

namespace ProjectPatterns.Factory.Pizzas
{
    public class AmericanCheesePizza : Pizza
    {
        public AmericanCheesePizza()
        {
            name = "Amerykanska Pizza Serowa";
            cake = "Extra grube, chrupkie ciasto";
            sauce = "Sos z pomidorow sliwkowych";

            toppings.Add("Grubo tarty ser Mozzarella");
        }

        public override void Baking()
        {
            Console.WriteLine("Krojenie pizzy na kwadratowe kawalki");
        }
    }
}
