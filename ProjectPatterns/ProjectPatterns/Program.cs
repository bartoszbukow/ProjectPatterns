using ProjectPatterns.Decorator.Abstract;
using ProjectPatterns.Decorator.Additives;
using ProjectPatterns.Decorator.Drinks;
using ProjectPatterns.Observer;
using ProjectPatterns.Strategy;
using ProjectPatterns.Strategy.Flying;
using System;

namespace ProjectPatterns
{
    class Program
    {
        static void Main()
        {
            //Strategy
            //Duck wild = new WildDuck();
            //wild.InvokeQuack();
            //wild.InvokeFly();

            //Duck model = new DuckModel();
            //model.InvokeFly();
            //model.SetFlying(new FlyWithRocketPropulsion());
            //model.InvokeFly();


            //Observer
            //WeatherData weatherData = new WeatherData();
            //DisplayCurrentConditional displayCurrentConditional = new DisplayCurrentConditional(weatherData);

            //weatherData.SetReadings(26.6f, 65, 1013.1f);


            //Decorator
            Drink drink = new Espresso();
            Console.WriteLine($"{drink.GetDescription()} {drink.Expense()}zl");

            Drink drink2 = new StrongRoasted();
            drink2 = new Chocolate(drink2);
            drink2 = new Chocolate(drink2);
            drink2 = new WhippedCream(drink2);

            Console.WriteLine($"{drink2.GetDescription()} {drink2.Expense()}zl");

            Drink drink3 = new StarCafeSpecial();
            drink3 = new SoyMilk(drink3);
            drink3 = new Chocolate(drink3);
            drink3 = new WhippedCream(drink3);

            Console.WriteLine($"{drink3.GetDescription()} {drink3.Expense()}zl");
        }
    }
}
