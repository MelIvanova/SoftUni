using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedPersons = new SortedSet<Person>();
            HashSet<Person> setPersons = new HashSet<Person>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);

                sortedPersons.Add(new Person(name, age));
                setPersons.Add(new Person(name, age));
            }

            Console.WriteLine(sortedPersons.Count);
            Console.WriteLine(setPersons.Count);
        }
    }
}
