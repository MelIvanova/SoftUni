using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input!= "End")
            {
                string[] info = input.Split();
                string name = info[0];
                string IDNumb = info[1];
                int age = int.Parse(info[2]);

                Student current = new Student(name, IDNumb, age);
                students.Add(current);

                input = Console.ReadLine();
            }

            students = students.OrderBy(x => x.Age).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public Student(string name, string IDNumb, int age)
        {
            Name = name;
            ID = IDNumb;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
