using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            double courses = people / capacity;
            courses = Math.Ceiling(courses);

            for (int i = 0; i <= courses; i++)
            {
                if (people >= capacity)
                {
                    people -= capacity;
                    count++;
                }
                else if(people< capacity && people > 0)
                {
                    count++;
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
