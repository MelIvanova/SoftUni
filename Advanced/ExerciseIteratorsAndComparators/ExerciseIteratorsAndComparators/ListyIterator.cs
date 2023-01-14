using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace GenericListyIterator 
{
    class ListyIterator <T> : IEnumerable<T>
    {
        private int index = 0;

        public ListyIterator(List<T> list)
        {
            List = new List<T>(list);
        }

        public List<T> List { get; set; }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext() => index < List.Count-1;


        public void Print()
        {
            if (index >= List.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(List[index]);
        }

        public void PrintAll()
        {
           IEnumerable<T> iteratedList = List;

            Console.WriteLine(String.Join((" "), iteratedList));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < List.Count; i++)
            {
                yield return List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
