using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Students
{

    class Program
    {
        static void Main(string[] args)
        {
            //John Smith 15 Sofia
            List<Student> students = new List<Student>();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            { 
                string[] input = command.Split();

                string firstName = input[0];
                string lastName = input[1];
                string age = input[2];
                string hometown = input[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = hometown;

                students.Add(student);

            }
            string targetInput = Console.ReadLine();
            foreach (Student currentStudent in students)
            {
                if (currentStudent.Hometown == targetInput)
                {
                    Console.
                    WriteLine("{0} {1} is {2} years old.",currentStudent.FirstName,currentStudent.LastName,currentStudent.Age);
                }
            }

        }
    }
}
