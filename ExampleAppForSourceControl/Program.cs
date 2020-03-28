using DynamicArrayNaiveImplementation;
using System;
using System.Collections.Generic;

namespace ExampleAppForSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IDynamicArray<int> dynamicArray = new DynamicArray<int>();

            for (int i = 1; i < 20; i++)
            {
                dynamicArray.Add(i);
            }

            dynamicArray.Remove(5);

        }       
    }
}
