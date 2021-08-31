
namespace ProjectPatterns.Iterator
{
    public class MenuPosition
    {
        readonly string name;
        readonly string description;
        readonly bool vegetarian;
        readonly decimal price;

        public MenuPosition(string name, string description, bool vegetarian, decimal price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetDesciption()
        {
            return this.description;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        public bool IsVegetarian()
        {
            return this.vegetarian;
        }
    }
}
