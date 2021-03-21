using ProjectPatterns.Decorator.Abstract;

namespace ProjectPatterns.Decorator.Drinks
{
    public class Decaffeinated : Drink
    {
        public Decaffeinated()
        {
            Desciption = "Kawa bezkofeinowa";
        }

        public override double Expense()
        {
            return 1.05;
        }
    }
}
