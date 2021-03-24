using ProjectPatterns.Factory.Abstract;
using ProjectPatterns.Factory.Pizzas;

namespace ProjectPatterns.Factory.Factories
{
    public class AmericanPizzeria : Pizzeria
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "serowa":
                    return new AmericanCheesePizza();
                case "wagetarianska":
                case "owoce morza":
                case "pepperoni":
                default:
                    return null;
            }
        }
    }
}
