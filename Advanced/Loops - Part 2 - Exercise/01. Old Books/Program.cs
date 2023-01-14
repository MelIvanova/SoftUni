using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        { 

            string book = Console.ReadLine();
            int library = int.Parse(Console.ReadLine()), i = 1;

            while (i <= library)
            {
                string checkBook = Console.ReadLine();
                if (checkBook == book)
                {
                    Console.WriteLine($"You checked {i-1} books and found it.");
                    break;
                }
                if(i==library&&checkBook!=book)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {i} books.");
                    break;
                }

                i++;

            }

            
        }
    }
}
