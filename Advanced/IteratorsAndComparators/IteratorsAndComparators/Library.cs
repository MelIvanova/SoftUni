using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book [] books)
        {
            Books = new SortedSet<Book>(books, new BookComparator());    
        }

        public SortedSet<Book> Books { get; private set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> bookList;

            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                bookList = new List<Book>(books);

            }

            public Book Current => bookList[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext() => ++currentIndex < bookList.Count;


            public void Reset()
            {
                currentIndex = -1;
            }
        }


        /*public IEnumerator <Book> GetEnumerator()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                yield return Books[i];
            }
        }*/
    }
}
