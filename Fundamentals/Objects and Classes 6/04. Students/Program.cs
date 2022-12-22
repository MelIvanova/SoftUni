using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student student = new Student(name, lastName, grade);
                students.Add(student);
            }

            students = students.OrderBy(x => x.Grade).ToList();
            students.Reverse();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }

    class Student
    {
        public Student(string name, string lastName, double grade)
        {
            FirstName = name;
            LastName = lastName;
            Grade = grade;
        }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}
}
