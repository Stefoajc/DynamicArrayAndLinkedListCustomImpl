using DynamicArrayNaiveImplementation;
using System;
using System.Collections.Generic;

namespace ExampleAppForSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDynamicArray<int> dynamicArray = new DynamicArray<int>();

            //for (int i = 1; i < 20; i++)
            //{
            //    dynamicArray.Add(i);
            //}

            //dynamicArray.Remove(5);


            //foreach (var item in dynamicArray)
            //{
            //    Console.WriteLine(item);
            //}

            ICustomLinkedListImplementation<int> array = new CustomLinkedListImplementation<int>();

            for (int i = 1; i < 20; i++)
            {
                array.AddLast(i);
            }

            array.RemoveFirst();
            array.RemoveLast();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
