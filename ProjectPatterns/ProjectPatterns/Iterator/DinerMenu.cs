using ProjectPatterns.Iterator.Abstract;
using ProjectPatterns.Iterator.Iterators;
using System;

namespace ProjectPatterns.Iterator
{
    public class DinerMenu : IMenu
    {
        private const int MAX_ELEMENT_COUNT = 6;
        private int elementCount = 0;
        readonly MenuPosition[] menuPositions;

        public DinerMenu()
        {
            this.menuPositions = new MenuPosition[MAX_ELEMENT_COUNT];

            AddElement("Wegetariańska kanapka BSP", "(Wegetariański) Boczek z sałatą i pomidorem, chleb pszenny pełnoziarnisty", true, 2.99m);
            AddElement("Kanapka BSP", "Boczek z sałatą i pomidorem, chleb pszenny pełnoziarnisty", false, 2.99m);
        }

        public void AddElement(string name, string description, bool vegetarian, decimal price)
        {
            var menuPosition = new MenuPosition(name, description, vegetarian, price);

            if(elementCount >= MAX_ELEMENT_COUNT)
            {
                Console.WriteLine("Niestety, menu jest pełne! Nie można dodać nowej pozycji");
            }
            else
            {
                this.menuPositions[elementCount] = menuPosition;
                this.elementCount++;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuPositions);
        }
    }
}
