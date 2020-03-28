using System;

namespace DynamicArrayNaiveImplementation
{
    public interface IDynamicArray<T>
    {
        void Add(T item);
        void Remove(int index);
        T GetValue(int index);
    }
}
