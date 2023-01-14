using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }

        public ListNode<T> Head { get; set; }

        public ListNode<T> Tail { get; set; }

        public void AddFirst(ListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                ListNode<T> current = Head;
                Head = node;
                Head.Next = current;
            }

            Count++;
        }

        public void AddLast(ListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                ListNode<T> current = Tail;
                Tail = node;
                Tail.Previous = current;
            }

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return Head.Value;
            for (int i = 1; i < Count; i++)
            {
                yield return Head.Next.Value;
            }
        }

        public ListNode<T> RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("This list is empthy");
            }
            ListNode<T> current = Head;
            Head = Head.Next;

            if (Head != null)
            {
                Head.Previous = null;
            }
            else
            {
                Tail= null;
            }
            Count--;
            return current;
        }

        public ListNode<T> RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("This list is empthy");
            }
            ListNode<T> current = Tail;
            Tail = Tail.Previous;

            if (Tail != null)
            {
                Head.Next= null;
            }
            else
            {
                Head = null;
            }
            Count--;
            return current;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
