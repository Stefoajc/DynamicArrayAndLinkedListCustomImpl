using System;
using System.Collections.Generic;

namespace DynamicArrayNaiveImplementation
{
    public interface IDynamicArray<T> : IEnumerable<T>
    {
        void Add(T item);
        void Remove(int index);
        T GetValue(int index);
    }
}
