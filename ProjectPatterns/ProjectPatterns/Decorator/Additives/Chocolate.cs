using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Additives
{
    public class Chocolate : DecoratorComponent
    {
        private readonly Drink _drink;

        public Chocolate(Drink drink)
        {
            _drink = drink;
        }

        public override double Expense()
        {
            return _drink.Expense() + 0.20;
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", Czekolada";
        }
    }
}
