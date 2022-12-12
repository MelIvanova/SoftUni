using System;
using System.Collections.Generic;

namespace _06._Students_2._0
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split();

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string hometown = input[3];

                if (IsStudentExisting(students, firstName, lastName))
                {

                    Student studentNew = GetStudent(students, firstName, lastName, age);
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;
                    students.Add(student);
                }
               

            }
           

            string targetInput = Console.ReadLine();
            foreach (Student currentStudent in students)
            {
                if (currentStudent.Hometown == targetInput)
                {
                    Console.
                    WriteLine("{0} {1} is {2} years old.", currentStudent.FirstName, currentStudent.LastName, currentStudent.Age);
                }
            }

            static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
            {
                foreach (Student student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        return true;
                    }
                }
                return false;
            }

            static Student GetStudent(List<Student> students, string firstName, string lastName, int age)
            {
                Student existingStudent = null;
                foreach (Student student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        existingStudent = student;
                        existingStudent.Age = age;
                    }
                }
                return existingStudent;
            }
        }
    }
    }

