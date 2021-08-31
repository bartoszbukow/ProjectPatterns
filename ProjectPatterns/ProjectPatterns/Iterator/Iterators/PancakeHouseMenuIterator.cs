using ProjectPatterns.Iterator.Abstract;
using System.Collections;

namespace ProjectPatterns.Iterator.Iterators
{
    public class PancakeHouseMenuIterator : IIterator
    {
        readonly ArrayList elements;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList elements)
        {
            this.elements = elements;
        }

        public object Next()
        {
            var menuPosition = elements[position];
            position++;
            return menuPosition;
        }

        public bool HasNext()
        {
            if (position >= elements.Count || elements[position] == null)
            {
                return false;
            }

            return true;
        }
    }
}
