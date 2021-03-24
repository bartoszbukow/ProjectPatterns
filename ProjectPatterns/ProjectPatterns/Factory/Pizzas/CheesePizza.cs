using ProjectPatterns.Factory.Abstract;
using System;

namespace ProjectPatterns.Factory.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientsFactory _pizzaIngredientsFactory;

        public CheesePizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Preparation()
        {
            Console.WriteLine($"Przygotowanie: {name}");
            cake = _pizzaIngredientsFactory.CreateCake();
            sauce = _pizzaIngredientsFactory.CreateSauce();
            Cheese = _pizzaIngredientsFactory.CreateCheese();
        }
    }
}
