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
using ProjectPatterns.Adapter;
using System;
using ProjectPatterns.Adapter.Abstract;
using ProjectPatterns.Iterator;
using ProjectPatterns.Composite.Abstract;
using ProjectPatterns.Composite;
using ProjectPatterns.State;

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
            //MiniRemoteControl remoteControl = new MiniRemoteControl();
            //Light light = new Light();
            //GarageDoor garageDoor = new GarageDoor();
            //TurnOnLightCommand turnOnLight = new TurnOnLightCommand(light);
            //OpenGarageDoorCommand openGarageDoor = new OpenGarageDoorCommand(garageDoor);

            //remoteControl.SetCommand(turnOnLight);
            //remoteControl.ButtonHasBeenPressed();
            //remoteControl.SetCommand(openGarageDoor);
            //remoteControl.ButtonHasBeenPressed();

            //SuperRemoteControl superRemoteControl = new SuperRemoteControl();

            //Light light = new Light();
            //GarageDoor garageDoor = new GarageDoor();
            //StereoSystem stereoSystem = new StereoSystem();

            //TurnOnLightCommand turnOnLight = new TurnOnLightCommand(light);
            //TurnOffLightCommand turnOffLight = new TurnOffLightCommand(light);
            //OpenGarageDoorCommand openGarageDoor = new OpenGarageDoorCommand(garageDoor);
            //CloseGarageDoorCommand closeGarageDoor = new CloseGarageDoorCommand(garageDoor);
            //TurnOnStereoSystemCDCommand turnOnStereoSystemCD = new TurnOnStereoSystemCDCommand(stereoSystem);
            //TurnOffStereoSystemCDCommand turnOffStereoSystemCD = new TurnOffStereoSystemCDCommand(stereoSystem);

            //superRemoteControl.SetCommand(0, turnOnLight, turnOffLight);
            //superRemoteControl.SetCommand(1, openGarageDoor, closeGarageDoor);
            //superRemoteControl.SetCommand(2, turnOnStereoSystemCD, turnOffStereoSystemCD);

            //superRemoteControl.OnTurnOnButtonPressed(0);
            //superRemoteControl.OnTurnOffButtonPressed(0);
            //superRemoteControl.OnDrawBackButtonPressed();

            //superRemoteControl.OnTurnOnButtonPressed(1);
            //superRemoteControl.OnTurnOffButtonPressed(1);
            //superRemoteControl.OnDrawBackButtonPressed();

            //superRemoteControl.OnTurnOnButtonPressed(2);
            //superRemoteControl.OnTurnOffButtonPressed(2);

            #endregion

            #region Adapter
            //IDuck duck = new Adapter.WildDuck();
            //ITurkey turkey = new WildTurkey();
            //IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            //Console.WriteLine("Inkdyk powiada tak...");
            //turkey.Gobble();
            //turkey.Fly();

            //Console.WriteLine("Kaczka powiada tak...");
            //duck.Quack();
            //duck.Fly();

            //Console.WriteLine("A indyk adapter powiada tak...");
            //turkeyAdapter.Quack();
            //turkeyAdapter.Fly();
            #endregion

            #region Iterator
            //var pancakeHouseMenu = new PancakeHouseMenu();
            //var dinerMenu = new DinerMenu();

            //var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            //waitress.PrintMenu();
            #endregion

            #region Composite
            //var pancakeHouseMenu = new Menu("MENU PANCAKE HOUSE", "Śniadania");
            //var dinerMenu = new Menu("MENU RESTAURACJI DINER", "Lunch");
            //var uJackaMenu = new Menu("MENU U JACKA", "Obiady");
            //var dessertsMenu = new Menu("MENU DESERÓW", "Desery, oczywiście!");

            //MenuComponent allComponents = new Menu("WSZYSTKIE MENU", "Połączone menu");

            //allComponents.Add(pancakeHouseMenu);
            //allComponents.Add(dinerMenu);
            //allComponents.Add(uJackaMenu);

            //dinerMenu.Add(new Composite.MenuPosition("Spaghetti", "Makaron spaghetti z sosem marinara i kromka chleba na zakwasie", true, 3.89m));
            //dinerMenu.Add(dessertsMenu);
            //dessertsMenu.Add(new Composite.MenuPosition("Szarlotka", "Szarlotka z lodami waniliowymi", true, 1.59m));

            //var waitress = new Composite.Waitress(allComponents);
            //waitress.Print();
            #endregion

            #region State
            var vendingMachine = new VendingMachine(5);

            Console.WriteLine(vendingMachine);

            vendingMachine.InsertCoin();
            vendingMachine.TwistKnob();

            Console.WriteLine(vendingMachine);

            vendingMachine.InsertCoin();
            vendingMachine.TwistKnob();
            vendingMachine.InsertCoin();
            vendingMachine.TwistKnob();

            Console.WriteLine(vendingMachine);
            #endregion
        }
    }
}
