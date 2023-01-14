using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _2Collection
{
    internal class CustonStack<T> : IEnumerable<T>
    {
        private readonly List<T> stack;

        public CustonStack(List <T> list)
        {
            stack = list;
        }

        public void Push(T element)
        {
            stack.Add(element);
        }

        public T Pop()
        {
            if (stack.Count <= 0)
            {
                throw new InvalidOperationException("No elements");
            }
            T element = stack[stack.Count - 1]; 
            stack.RemoveAt(stack.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
