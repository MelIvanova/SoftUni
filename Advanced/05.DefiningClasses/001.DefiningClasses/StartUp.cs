using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split();
                Person current = new Person(personData[0], int.Parse(personData[1]));
                people.Add(current);
            }

            people = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }



            //Family family = new Family();

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    Person curr = new Person(input[0], int.Parse(input[1]));
            //    family.AddMember(curr);
            //}


            //Person oldest = family.GetOldestMember();

            //Console.WriteLine($"{oldest.Name} {oldest.Age}");

        }
    }
}
