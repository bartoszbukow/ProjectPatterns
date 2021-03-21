using ProjectPatterns.Factory.Abstract;
using ProjectPatterns.Factory.Pizzas;

namespace ProjectPatterns.Factory.Factories
{
    public class ItalianPizzeria : Pizzeria
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "serowa":
                    return new ItalianCheesePizza();
                case "wagetarianska":
                case "owoce morza":
                case "pepperoni":
                default:
                    return null;
            }
        }
    }
}
