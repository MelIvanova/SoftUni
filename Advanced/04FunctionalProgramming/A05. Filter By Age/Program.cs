using System;

namespace A05._Filter_By_Age
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                people[i] = new Person();
                string[] input = Console.ReadLine().Split(", ");
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string command = Console.ReadLine();
            int ageBorder = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            
            Func<Person, bool> condition = AgeCondition(command, ageBorder);
            
            Action<Person> formating = Format(format);
            
            Printer(people, condition, formating);
        }

        static Func<Person, bool> AgeCondition(string command, int ageBorder)
        {
            switch (command)
            {
                case "younger": return p => p.Age < ageBorder;
                case "older": return p => p.Age >= ageBorder;
                default: return null;
            }
        }

        static Action<Person> Format(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };

                default: return null;

            }
        }

        static void Printer(Person[] people, Func<Person, bool> filter, Action<Person> format)
        {
            foreach (var person in people)
            {
                if (filter(person))
                {
                    format(person);
                }
            }
        }

    }
}


