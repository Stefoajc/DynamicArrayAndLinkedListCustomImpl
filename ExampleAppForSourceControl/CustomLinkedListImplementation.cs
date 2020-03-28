using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAppForSourceControl
{
    public class CustomLinkedListImplementation
    {
        public Node FirstElement { get; private set; }
        public Node LastElement { get; private set; }

        public void AddFirst(string item)
        {
            if (IsEmpty())
            {
                FirstElement = LastElement = new Node(item);
            }
            else
            {
                var itemToAdd = new Node(item, FirstElement);
                FirstElement.Previous = itemToAdd;
                FirstElement = itemToAdd;
            }
            //...
        }



        public void AddLast(string item)
        {

        }

        public void RemoveFirst()
        {

            throw new NotImplementedException();
        }

        public void RemoveLast()
        {

            throw new NotImplementedException();
        }

        public Node Find(string item)
        {
            return null;
        }

        private bool IsEmpty() => FirstElement == null && LastElement == null;

    }

    public class Node
    {
        public string Item { get; private set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(string item
            , Node next = null
            , Node previous = null)
        {
            Item = item;
            Next = next;
            Previous = previous;
        }
    }
}
