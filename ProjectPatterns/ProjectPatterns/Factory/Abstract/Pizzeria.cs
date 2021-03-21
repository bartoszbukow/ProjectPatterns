
namespace ProjectPatterns.Factory.Abstract
{
    public abstract class Pizzeria
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Preparation();
            pizza.Baking();
            pizza.Slicing();
            pizza.Packing();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
