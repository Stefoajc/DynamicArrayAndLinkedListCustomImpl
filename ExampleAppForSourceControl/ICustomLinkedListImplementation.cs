using System.Collections.Generic;

namespace ExampleAppForSourceControl
{
    public interface ICustomLinkedListImplementation<T>
    {
        void AddFirst(T item);
        void AddLast(T item);
        IEnumerator<T> GetEnumerator();
        void RemoveFirst();
        void RemoveLast();
    }
}