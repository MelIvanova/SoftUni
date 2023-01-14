using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "END")
            {
                people.Add(new Person(input[0], int.Parse(input[1]), input[2]));
                input = Console.ReadLine().Split(' ');
            }

            int position = int.Parse(Console.ReadLine());

            Person toBeCompare = people[position - 1];
            int matched = 0;
            int notMatched = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(toBeCompare) == 0)
                {
                    matched++;
                }
                else
                {
                    notMatched++;
                }
            }

            if (matched <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matched} {notMatched} {people.Count}");
            }
        }
    }
}
