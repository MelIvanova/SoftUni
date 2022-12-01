using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double curentRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double timeIvan = meters * timeFor1Meter;
            double slowingMeters1 = meters / 15 ;
            double slowingMeters2 = Math.Floor(slowingMeters1);
            double slowingTime = slowingMeters2 * 12.5;
            double totalTimeIvan = timeIvan + slowingTime;

            if(curentRecord<=totalTimeIvan)
            {
                double slowerTime = totalTimeIvan - curentRecord;
                Console.WriteLine($"No, he failed! He was {slowerTime:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeIvan:F2} seconds.");
            }

        }
    }
}
