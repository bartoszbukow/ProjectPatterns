using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Drinks
{
    public class StarCafeSpecial : Drink
    {
        public StarCafeSpecial()
        {
            Desciption = "Kawa Star Cafe Special";
        }

        public override double Expense()
        {
            return 0.89;
        }
    }
}
