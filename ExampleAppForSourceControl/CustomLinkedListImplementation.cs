using System;
using System.Collections;
using System.Collections.Generic;

namespace ExampleAppForSourceControl
{
    public class CustomLinkedListImplementation<T> : IEnumerable<T>, ICustomLinkedListImplementation<T>
    {
        private Node<T> FirstElement { get; set; }
        private Node<T> LastElement { get; set; }

        public void AddFirst(T item)
        {
            if (IsEmpty())
            {
                FirstElement = LastElement = new Node<T>(item);
            }
            else
            {
                var nodeToAdd = new Node<T>(item, FirstElement);
                FirstElement.Previous = nodeToAdd;
                FirstElement = nodeToAdd;
            }
        }



        public void AddLast(T item)
        {
            if (IsEmpty())
            {
                FirstElement = LastElement = new Node<T>(item);
            }
            else
            {
                var nodeToAdd = new Node<T>(item, null, LastElement);
                LastElement.Next = nodeToAdd;
                LastElement = nodeToAdd;
            }
        }

        public void RemoveFirst()
        {
            if (IsListOfOne())
            {
                FirstElement = LastElement = null;
            }
            else
            {
                //Save reference to the first element
                var oldFirstElement = FirstElement;
                //Set the current First with the next
                FirstElement = FirstElement.Next;
                //Remove the link between the first and the second element 
                //(FirstElement is the current second, oldFirstElement is the original first)
                FirstElement.Previous = oldFirstElement.Next = null;
            }
        }

        public void RemoveLast()
        {
            if (IsListOfOne())
            {
                FirstElement = LastElement = null;
            }
            else
            {
                //Save reference to the last element
                var oldLastElement = LastElement;
                //Set the current Last with the previous
                LastElement = LastElement.Previous;
                //Remove the link between the last and the one before the last 
                //(LastElement is the current second last, oldLastElement is the original last)
                oldLastElement.Previous = LastElement.Next = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = FirstElement;
            yield return current.Item;

            while (current.Next != null)
            {
                current = current.Next;
                yield return current.Item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private bool IsEmpty() => FirstElement == null && LastElement == null;

        private bool IsListOfOne() => FirstElement == LastElement;
    }

    public class Node<T>
    {
        public T Item { get; private set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T item
            , Node<T> next = null
            , Node<T> previous = null)
        {
            Item = item;
            Next = next;
            Previous = previous;
        }
    }
}
