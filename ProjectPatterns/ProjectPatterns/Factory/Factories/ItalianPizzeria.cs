using ProjectPatterns.Factory.Abstract;
using ProjectPatterns.Factory.Pizzas;

namespace ProjectPatterns.Factory.Factories
{
    public class ItalianPizzeria : Pizzeria
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientsFactory PizzaIngredientsFactory = new ItalianPizzaIngredientsFactory();

            switch (type)
            {
                case "serowa":
                    pizza = new CheesePizza(PizzaIngredientsFactory);
                    pizza.name = "Wloska pizza serowa";
                    break;
                case "wagetarianska":
                case "owoce morza":
                case "pepperoni":
                default:
                    break;
            }

            return pizza;
        }
    }
}
