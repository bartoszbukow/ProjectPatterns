using ProjectPatterns.Factory.Abstract.Ingredients;
using System.Collections.Generic;

namespace ProjectPatterns.Factory.Abstract
{
    public interface IPizzaIngredientsFactory
    {
        public ICake CreateCake();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public List<IVegetables> CreateVegetables();
        public IPepperoni CreatePepperoni();
        public IMussels CreateMussels();
    }
}
