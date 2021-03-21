
namespace ProjectPatterns.Decorator.Abstract
{
    public abstract class Drink
    {
        public string Desciption = "Napoj nieznany";

        public virtual string GetDescription()
        {
            return Desciption;
        }

        public abstract double Expense();
    }
}
