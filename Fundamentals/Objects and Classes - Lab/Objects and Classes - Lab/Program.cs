using System;
using System.Globalization;

namespace Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayasString = Console.ReadLine();
            DateTime weekDay = DateTime.ParseExact(dayasString,"dd-MM-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(weekDay.DayOfWeek);
        }
    }
}
