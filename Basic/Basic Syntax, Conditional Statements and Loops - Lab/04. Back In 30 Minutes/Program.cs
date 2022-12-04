using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int houers = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes>59)
            {
                houers += 1;
                minutes -= 60;
            }
            if (houers>23)
            {
                houers = 0;
            }
            Console.WriteLine($"{houers}:{minutes:D2}");
        }
    }
}
