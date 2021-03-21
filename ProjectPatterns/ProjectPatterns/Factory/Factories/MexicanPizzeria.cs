using ProjectPatterns.Factory.Abstract;
using ProjectPatterns.Factory.Pizzas;

namespace ProjectPatterns.Factory.Factories
{
    public class MexicanPizzeria : Pizzeria
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "serowa":
                    return new MexicanCheesePizza();
                case "wagetarianska":
                case "owoce morza":
                case "pepperoni":
                default:
                    return null;
            }
        }
    }
}
