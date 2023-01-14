using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class DounleLinkedList
    {
        private int Count = 0;

        private bool Direction = true;

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddFitst(Node node)
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

        public void AddLast (Node node)
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

        public Node RemoveFirst()
        {

            if (Head == null)
            {
                return null;
            }

            Node nodeReturn = Head;

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

        public Node RemoveTail ()
        {
            if (Tail == null)
            {
                return null;
            }

            Node nodeReturn = Tail;

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

        public void ForEach(Action <Node> action)
        {
            Node current = Head;

            while (current != null)
            {
                action(current);

                if (Direction)
                {
                    current = current.Previous;
                }
                else
                {
                    current = current.Next;
                }
                
            }
        }

        public int [] ToArray()
        {
            int index = 0;
            int[] nodes = new int[Count];
            ForEach((element) =>
            {
                nodes[index] = element.Value;
                index++;
            });

            return nodes;
        }

        public void Reverse()
        {
            Node current = Head;
            Head = Tail;
            Tail = current;
            Direction = !Direction;
        }
    }
}
