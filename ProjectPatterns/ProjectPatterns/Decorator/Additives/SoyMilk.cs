using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Additives
{
    public class SoyMilk : DecoratorComponent
    {
        private readonly Drink _drink;

        public SoyMilk(Drink drink)
        {
            _drink = drink;
        }

        public override double Expense()
        {
            return _drink.Expense() + 0.15;
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", Mleko sojowe";
        }
    }
}
