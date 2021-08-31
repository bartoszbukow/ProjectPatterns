using ProjectPatterns.Iterator.Abstract;
using System;

namespace ProjectPatterns.Iterator
{
    public class Waitress
    {
        readonly IMenu pancakeHouseMenu;
        readonly IMenu dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nŚNIADANIE");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);

        }

        private void PrintMenu(IIterator iterator)
        {
            while(iterator.HasNext()){
                var menuPosition = (MenuPosition)iterator.Next();

                Console.WriteLine(menuPosition.GetName() + ", ");
                Console.WriteLine(menuPosition.GetPrice() + " -- ");
                Console.WriteLine(menuPosition.GetDesciption());
            }
        }
    }
}
