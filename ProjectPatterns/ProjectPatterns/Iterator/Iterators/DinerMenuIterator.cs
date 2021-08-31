using ProjectPatterns.Iterator.Abstract;

namespace ProjectPatterns.Iterator.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        readonly MenuPosition[] elements;
        int position = 0;

        public DinerMenuIterator(MenuPosition[] elements)
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
            if(position >= elements.Length || elements[position] == null)
            {
                return false;
            }

            return true;
        }
    }
}
