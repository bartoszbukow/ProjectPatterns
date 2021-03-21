using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Drinks
{
    public class Espresso : Drink
    {
        public Espresso()
        {
            Desciption = "Kawa Espresso";
        }

        public override double Expense()
        {
            return 1.99;
        }
    }
}
