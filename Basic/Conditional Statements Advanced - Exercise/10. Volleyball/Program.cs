using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int goHome = int.Parse(Console.ReadLine());
            int weekends = 48;
            double playInHolydays = holydays * (2.0 / 3.0);
            double playSaterday = (weekends - goHome) *0.75;
            double totoalPlayDays = goHome + playInHolydays + playSaterday;

            switch(year)
            {
                case "leap":
                    totoalPlayDays += totoalPlayDays * 0.15;
                    Console.WriteLine($"{Math.Floor(totoalPlayDays)}");
                    break;
                case "normal":
                    Console.WriteLine($"{Math.Floor(totoalPlayDays)}");
                    break;
            }

        }
    }
}
