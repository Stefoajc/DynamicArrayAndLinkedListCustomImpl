using System.Collections.Generic;

namespace DynamicArrayNaiveImplementation
{

    /// <summary>
    /// This class is wrapper around List<T> implementation 
    /// which provides implementation for IDynamicArray
    /// </summary>
    public class DynamicArrayWithList<T> : IDynamicArray<T>
    {
        private List<T> array;

        public void Add(T item)
        {
            array.Add(item);
        }

        public T GetValue(int index)
        {
            return array[index];
        }

        public void Remove(int index)
        {
            var element = array[index];
            array.Remove(element);
        }
    }
}
