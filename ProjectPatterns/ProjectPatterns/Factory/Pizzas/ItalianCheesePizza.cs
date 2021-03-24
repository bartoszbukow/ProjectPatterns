using ProjectPatterns.Factory.Abstract;

namespace ProjectPatterns.Factory.Pizzas
{
    public class ItalianCheesePizza : Pizza
    {
        public ItalianCheesePizza()
        {
            name = "Wloska pizza serowa z sosem Marinara";
        }

        public override void Preparation()
        {
            throw new System.NotImplementedException();
        }
    }
}
