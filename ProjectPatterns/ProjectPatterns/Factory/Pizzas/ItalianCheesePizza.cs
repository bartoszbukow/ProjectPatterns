using ProjectPatterns.Factory.Abstract;

namespace ProjectPatterns.Factory.Pizzas
{
    public class ItalianCheesePizza : Pizza
    {
        public ItalianCheesePizza()
        {
            name = "Wloska pizza serowa z sosem Marinara";
            cake = "Cienkie kruche ciasto";
            sauce = "Sos Marinara";

            toppings.Add("Tarty ser Reggiano");
        }
    }
}
