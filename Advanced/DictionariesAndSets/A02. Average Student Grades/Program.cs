using System;
using System.Collections.Generic;
using System.Linq;

namespace A02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split();
                string student = information[0];
                decimal grade = decimal.Parse(information[1]);
                if (!grades.ContainsKey(student))
                {
                    grades[student] = new List<decimal>();
                }

                grades[student].Add(grade);
            }

            foreach (var student in grades)
            {
                Console.Write($"{student.Key} ->");

                foreach (var grade in student.Value)
                {
                    Console.Write($" {grade:f2}");
                }

                Console.WriteLine($" (avg: {student.Value.Average():f2})");
            }
        }
    }
}
