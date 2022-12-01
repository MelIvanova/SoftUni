using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int houers = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int houersToMinutes = houers * 60;
            int allMinutes = houersToMinutes + minutes + 15;
            int houersFinal = allMinutes / 60;
            int minutesFinal = allMinutes % 60;
        
            if (houersFinal==24)
            {
                houersFinal = 00;
            }

            Console.WriteLine($"{houersFinal}:{minutesFinal:D2}");
            


        }
    }
}
