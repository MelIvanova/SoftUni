using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentsGrades = new Dictionary<string, double>();

            for (int i = 0; i < rows; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, grade);
                }
                else
                {
                    studentsGrades[student] = (studentsGrades[student] + grade) / 2;
                }
            }
            studentsGrades = studentsGrades.Where(x => x.Value >= 4.5)
                .OrderByDescending(x=>x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in studentsGrades)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
