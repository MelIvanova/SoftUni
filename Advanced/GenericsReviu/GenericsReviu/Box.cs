using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        
       /* private List<T> elements;

        public Box()
        {
            elements = new List<T>();
        }

        public int Count => elements.Count;

        public void Add(T element)
        {
            elements.Insert(0, element);
        }

        public T Remove()
        {
            T element = elements[0];
            elements.RemoveAt(0);
            return element;
        }*/



        Stack<T> stackElements;

          public Box()
          {
              stackElements = new Stack<T>();
          }

        public int Count { get { return stackElements.Count; } }

        public void Add(T element)
        {
            stackElements.Push(element);
        }

        public T Remove()
        {
            T removedElement = stackElements.Pop();
            return removedElement;
        }

    }
}
