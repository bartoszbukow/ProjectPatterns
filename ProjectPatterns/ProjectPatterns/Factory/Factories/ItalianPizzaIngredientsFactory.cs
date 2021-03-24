using ProjectPatterns.Factory.Abstract;
using ProjectPatterns.Factory.Abstract.Ingredients;
using ProjectPatterns.Factory.Ingredients.ItalianIngredients;
using System.Collections.Generic;

namespace ProjectPatterns.Factory.Factories
{
    public class ItalianPizzaIngredientsFactory : IPizzaIngredientsFactory
    {
        public ICake CreateCake()
        {
            return new ThinCrispyCake();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IMussels CreateMussels()
        {
            return new FreshMussels();
        }

        public IPepperoni CreatePepperoni()
        {
            return new PepperoniSlices();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVegetables> CreateVegetables()
        {
            return new List<IVegetables>();
        }
    }
}
