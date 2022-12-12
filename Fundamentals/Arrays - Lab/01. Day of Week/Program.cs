using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());
            string[] dayOfWeek = new string[] {"Monday",
                                                "Tuesday",
                                                "Wednesday",
                                                "Thursday",
                                                "Friday",
                                                "Saturday",
                                                "Sunday" };
             if (0<+ numberOfDay && numberOfDay <= dayOfWeek.Length)
            {
                Console.WriteLine(dayOfWeek[numberOfDay-1]);
            }
         
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
