using System;

namespace ProjectPatterns.Iterator.Abstract
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
