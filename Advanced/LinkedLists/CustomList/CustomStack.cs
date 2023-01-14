using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
   public class CustomStack
    {
        private const int Capacity = 4;
        
        private int[] array;

        private int Count { get;  set; }
        
        public CustomStack()
        {
            array = new int[Capacity];
        }

        /*public int this[int index]
        {
            get
            {
                if (index>=Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return array[index];

            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                array[index] = value;
            }
        }*/

        public void Push(int element)
        {
            if (array.Length==Count)
            {
                Resize();
            }

            array[Count] = element;

            Count++;
        }

        public int Pop()
        {
            if (Count>0)
            {
                int element = array[Count - 1];
                array[Count - 1] = default;
                Count--;

                if (Count == array.Length/4)
                {
                    Shrink();
                }

                return element;
            }
            else
            {
                throw new InvalidOperationException();
            }
            
        }

        public int Peek()
        {
            if (Count > 0)
            {
                int element = array[Count - 1];
 
                return element;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void ForEach (Action<object> action)
        {
            foreach (var item in array)
            {
                if (Count == 0)
                {
                    break;
                }
                action(item);
            }
        }

        public void Select (Func<int, int> func)
        {
            for (int i = 0; i < Count; i++)
            {
                int element = func(array[i]);
                array[i] = element;
            }
        }

        private void Resize()
        {
            int[] resize = new int[array.Length * 2];
            Array.Copy(array, resize, Count);
            array = resize;
        }

        private void Shrink()
        {
            int[] resize = new int[array.Length / 2];
            Array.Copy(array, resize, Count);
            array = resize;
        }
    }
}
