using System;

namespace DynamicArrayNaiveImplementation
{
    public class DynamicArray<T> : IDynamicArray<T>
    {
        private T[] array = new T[10];

        public void Add(T element)
        {
            // 1. Check if the array is full
            // 2. Array is not full
            //   2.1 Add element after the last element in the array
            // 3. Array is full
            //   3.1 Create new array with size of the old one + 1
            //   3.2 Copy the elements from the old array to the newly created one
            //   3.3 Assign the newly created array to the "array" variable
            //   3.4 Add the element passed into the function to the newly created slot   

            if (AnyEmptyCell())
            {
                int emptyCellIndex = GetEmptyCellIndex();
                array[emptyCellIndex] = element;
            }
            else
            {
                var expandedArray = new T[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    expandedArray[i] = array[i];
                }
                array = expandedArray;
                array[array.Length - 1] = element;
            }

        }

        public T GetValue(int index)
        {
            return array[index];
        }

        public void Remove(int index)
        {
            T[] arrayFromStartToIndex = array[0..(index-1)];
            T[] arrayFromIndexToEnd = array[index..];

            array = new T[array.Length - 1];
            arrayFromStartToIndex.CopyTo(array, 0);
            arrayFromIndexToEnd.CopyTo(array, arrayFromStartToIndex.Length);
        }


        private bool AnyEmptyCell()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(default(T)))
                {
                    return true;
                }
            }

            return false;
        }

        private int GetEmptyCellIndex()
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(default(T)))
                {
                    return i;
                }
            }

            throw new Exception();
        }
    }


}
