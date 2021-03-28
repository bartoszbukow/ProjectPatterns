using ProjectPatterns.Command;
using ProjectPatterns.Command.Commands;
using ProjectPatterns.Command.Objects;
using ProjectPatterns.Decorator.Abstract;
using ProjectPatterns.Decorator.Additives;
using ProjectPatterns.Decorator.Drinks;
using ProjectPatterns.Factory.Abstract;
using ProjectPatterns.Factory.Factories;
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
            #region Strategy
            //Duck wild = new WildDuck();
            //wild.InvokeQuack();
            //wild.InvokeFly();

            //Duck model = new DuckModel();
            //model.InvokeFly();
            //model.SetFlying(new FlyWithRocketPropulsion());
            //model.InvokeFly();
            #endregion

            #region Observer
            //WeatherData weatherData = new WeatherData();
            //DisplayCurrentConditional displayCurrentConditional = new DisplayCurrentConditional(weatherData);

            //weatherData.SetReadings(26.6f, 65, 1013.1f);
            #endregion

            #region Decorator
            //    Drink drink = new Espresso();
            //    Console.WriteLine($"{drink.GetDescription()} {drink.Expense()}zl");

            //    Drink drink2 = new StrongRoasted();
            //    drink2 = new Chocolate(drink2);
            //    drink2 = new Chocolate(drink2);
            //    drink2 = new WhippedCream(drink2);

            //    Console.WriteLine($"{drink2.GetDescription()} {drink2.Expense()}zl");

            //    Drink drink3 = new StarCafeSpecial();
            //    drink3 = new SoyMilk(drink3);
            //    drink3 = new Chocolate(drink3);
            //    drink3 = new WhippedCream(drink3);

            //    Console.WriteLine($"{drink3.GetDescription()} {drink3.Expense()}zl");
            //}
            #endregion

            #region Factory
            //Pizzeria wloska = new ItalianPizzeria();
            //Pizzeria amerykanska = new AmericanPizzeria();

            //Pizza pizza = wloska.OrderPizza("serowa");
            //Console.WriteLine($"Eryk zamowil: {pizza.GetName()}");

            //pizza = amerykanska.OrderPizza("serowa");
            //Console.WriteLine($"Jacek zamowil: {pizza.GetName()}");
            #endregion

            #region Command
            MiniRemoteControl remoteControl = new MiniRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            TurnOnLightCommand turnOnLight = new TurnOnLightCommand(light);
            OpenGarageDoorCommand openGarageDoor = new OpenGarageDoorCommand(garageDoor);

            remoteControl.SetCommand(turnOnLight);
            remoteControl.ButtonHasBeenPressed();
            remoteControl.SetCommand(openGarageDoor);
            remoteControl.ButtonHasBeenPressed();

            #endregion
        }
    }
}
