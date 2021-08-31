using System;

namespace ProjectPatterns.Composite.Abstract
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Delete(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual decimal GetPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
