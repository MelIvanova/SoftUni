using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book 
    {
       /* public Book(string name, int year, IEnumerable<string> autors)
        {
            Title = name;
            Year = year;
            Authors = new List<string>(autors);
        }*/


        public Book( string name, int year, params string [] autors)
        {
            Title = name;
            Year = year;
            Authors = new List<string>();
            for (int i = 0; i < autors.Length; i++)
            {
                Authors.Add(autors[i]);
            }
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; private set; }

       /* public int CompareTo(Book other)
        {
           int result = Year.CompareTo(other.Year);
            
            if (result == 0)
            {
                result = Title.CompareTo(other.Title);
            }

            return result;
        }*/

        public override string ToString()
        {
           return $"{Title} - {Year}";
        }
    }
}
