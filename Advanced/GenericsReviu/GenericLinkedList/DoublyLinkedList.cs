using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private int Count = 0;

        private bool Direction = true;

        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public void AddFitst(Node<T> node)
        {
            Count++;

            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }

        public void AddLast(Node<T> node)
        {
            Count++;
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public Node<T> RemoveFirst()
        {

            if (Head == null)
            {
                return default;
            }

            Node<T> nodeReturn = Head;

            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }

            Count--;

            return nodeReturn;
        }

        public Node<T> RemoveTail()
        {
            if (Tail == null)
            {
                return default;
            }

            Node<T> nodeReturn = Tail;

            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Tail = null;
                Head = null;
            }

            Count--;

            return nodeReturn;
        }

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> current = Head;

            while (current != null)
            {
                action(current);

                if (!Direction)
                {
                    current = current.Previous;
                }
                else
                {
                    current = current.Next;
                }

            }
        }

        public T[] ToArray()
        {
            int index = 0;
            T[] nodes = new T[Count];
            ForEach((element) =>
            {
                nodes[index] = element.Value;
                index++;
            });

            return nodes;
        }

        public void Reverse()
        {
            Node<T> current = Head;
            Head = Tail;
            Tail = current;
            Direction = !Direction;
        }

    }
}
