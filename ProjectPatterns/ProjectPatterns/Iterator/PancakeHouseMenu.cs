using ProjectPatterns.Iterator.Abstract;
using ProjectPatterns.Iterator.Iterators;
using System.Collections;

namespace ProjectPatterns.Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        readonly ArrayList menuPositions;

        public PancakeHouseMenu()
        {
            this.menuPositions = new ArrayList();

            AddElement("Śniadanie naleśnikowe K&B", "Naleśnik z jajecznica i tostem", true, 2.99m);
            AddElement("Śniadanie naleśnikowe zwykłe", "Naleśnik z jajkiem sadzonym i kiełbasa", false, 2.99m);
            AddElement("Śniadanie z jagodami", "Naleśnik ze świeżymi jagodami", true, 3.49m);
            AddElement("Wafle nadziewane", "Wafle z jagodami lub truskawkami", true, 3.59m);
        }

        public void AddElement(string name, string description, bool vegetarian, decimal price)
        {
            var menuPosition = new MenuPosition(name, description, vegetarian, price);
            menuPositions.Add(menuPosition);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuPositions);
        }
    }
}
