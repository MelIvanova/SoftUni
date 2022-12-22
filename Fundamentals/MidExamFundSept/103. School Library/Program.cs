using System;
using System.Collections.Generic;
using System.Linq;

namespace _103._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bookshelf = Console.ReadLine().Split('&').ToList();
            string[] command = Console.ReadLine().Split(" | ");

            while (command[0]!= "Done")
            {
                if (command[0] == "Add Book")
                {
                    string book = command[1];

                    if (!bookshelf.Contains(book))
                    {
                        bookshelf.Insert(0, book);
                    }
                }
                else if (command[0] == "Take Book")
                {
                    string book = command[1];

                    if (bookshelf.Contains(book))
                    {
                        bookshelf.Remove(book);
                    }
                }
                else if (command[0] == "Swap Books")
                {
                    string firstBook = command[1];
                    string secondBook = command[2];

                    if (bookshelf.Contains(firstBook)&& bookshelf.Contains(secondBook))
                    {
                        int indexBook1 = bookshelf.IndexOf(firstBook);
                        int indexBook2 = bookshelf.IndexOf(secondBook);

                        bookshelf.Insert(indexBook1, secondBook);
                        bookshelf.RemoveAt(indexBook1 + 1);
                        bookshelf.Insert(indexBook2, firstBook);
                        bookshelf.RemoveAt(indexBook2 + 1);
                    }
                }
                else if (command[0] == "Insert Book")
                {
                    bookshelf.Add(command[1]);
                }
                else if (command[0] == "Check Book")
                {
                    int index = int.Parse(command[1]);

                    if (index< bookshelf.Count)
                    {
                        Console.WriteLine(bookshelf[index]);
                    }
                }

                command = Console.ReadLine().Split(" | ");
            }

            Console.WriteLine(string.Join(", ", bookshelf));
        }
    }
}
