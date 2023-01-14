using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class CutomList
    {
        private const int InitialCapacity = 2;

        private int[] items;

        public CutomList()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }

        private void Resize()
        {
            /*int[] curr = new int[items.Length];
            int[] resize = (int [])items.Concat(curr);*/

            int[] resize = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                resize[i] = items[i];
            }

            items = resize;
        }

        public void Add(int element)
        {

            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = element;
            Count++;
        }

        private void Shrink()
        {
            int[] shrink = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                shrink[i] = items[i];
            }

            items = shrink;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            Count--;
        }

        public int RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int valueToRemove = items[index];
            items[index] = default(int);
            Shift(index);

            if (Count < items.Length / 4)
            {
                Shrink();
            }
            return valueToRemove;

        }

        public bool Contains (int element)
        {

            for (int i = 0; i < Count; i++)
            {
                if (items[i] == element)
                {
                    return true; 
                }
            }

            return false;
        }

        public void Swap (int firstIndex, int secondIndex)
        {
            if (firstIndex >= Count || secondIndex >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            int current = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = current;
        }

        public void Insert (int index, int element)
        {
            if (index>Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            Count++;

            if (Count == items.Length)
            {
                Resize();
            }

            int bufer = items[index];
            items[index] = element;

            for (int i = index +1 ; i < Count; i++)
            {
                int curr = items[i];
                items[i] = bufer;
                bufer = curr;
            }
        }
    }
}

