using ProjectPatterns.Composite.Abstract;
using System;
using System.Collections;

namespace ProjectPatterns.Composite
{
    public class Menu : MenuComponent
    {
        readonly ArrayList menuComponents = new ArrayList();
        readonly string name;
        readonly string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Delete(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Console.WriteLine("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("------------");

            foreach(var iterator in menuComponents)
            {
                ((MenuComponent)iterator).Print();
            }
        }
    }
}
