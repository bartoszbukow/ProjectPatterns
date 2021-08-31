using ProjectPatterns.Composite.Abstract;

namespace ProjectPatterns.Composite
{
    public class Waitress
    {
        MenuComponent allComponents;

        public Waitress(MenuComponent allComponents)
        {
            this.allComponents = allComponents;
        }

        public void Print()
        {
            allComponents.Print();
        }
    }
}
