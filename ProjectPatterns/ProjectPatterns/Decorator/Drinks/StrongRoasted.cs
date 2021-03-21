using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Drinks
{
    public class StrongRoasted : Drink
    {
        public StrongRoasted()
        {
            Desciption = "Kawa mocna palona";
        }

        public override double Expense()
        {
            return 0.99;
        }
    }
}
