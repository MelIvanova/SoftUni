using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesList = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arguments = input.Split(" : ");
                string course = arguments[0];
                string student = arguments[1];

                if (!coursesList.ContainsKey(course))
                {
                    coursesList.Add(course, new List<string>());
                    coursesList[course].Add(student);
                }
                else
                {
                    coursesList[course].Add(student);
                }
        
                input = Console.ReadLine();
            }

            coursesList = coursesList.OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x =>x.Value.OrderBy(x=>x).ToList());

            foreach (var kvp in coursesList)
            {
                int number = kvp.Value.Count;
                Console.WriteLine($"{kvp.Key}: {number}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
