using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
   public class Box <T>
    {
        Stack<T> elements;

        public Box()
        {
            elements = new Stack<T>();
        }

        public int Count => elements.Count;

        public void Add(T element) 
        {
            elements.Push(element);
        }

        public T Remove()
        {
            T removedElement = elements.Pop();
            return removedElement;
        }
    }
}
