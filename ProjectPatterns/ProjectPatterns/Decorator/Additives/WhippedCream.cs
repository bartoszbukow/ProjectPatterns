using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Additives
{
    public class WhippedCream : DecoratorComponent
    {
        private readonly Drink _drink;

        public WhippedCream(Drink drink)
        {
            _drink = drink;
        }

        public override double Expense()
        {
            return _drink.Expense() + 0.10;
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", Bita smietana";
        }
    }
}
