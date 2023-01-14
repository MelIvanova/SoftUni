using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            DateModifier modifire = new DateModifier();

            int days = modifire.DaysBetwinDates(startDate, endDate);

            Console.WriteLine(days);
        }
    }
}
