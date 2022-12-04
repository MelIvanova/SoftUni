using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruizTipe = Console.ReadLine();
            string cabbin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double cost = 0;
            double sum = 0;

            if (cruizTipe == "Mediterranean")
            {
                switch(cabbin)
                {
                    case "standard cabin":
                        cost = 27.50;
                        break;
                    case "cabin with balcony":
                        cost = 30.20;
                        break;
                    case "apartment":
                        cost = 40.50;
                        break;
                }
            }
            if (cruizTipe == "Adriatic")
            {
                switch (cabbin)
                {
                    case "standard cabin":
                        cost = 22.99;
                        break;
                    case "cabin with balcony":
                        cost = 25.00;
                        break;
                    case "apartment":
                        cost = 34.99;
                        break;
                }
            }
            if (cruizTipe == "Aegean")
            {
                switch (cabbin)
                {
                    case "standard cabin":
                        cost = 23.00;
                        break;
                    case "cabin with balcony":
                        cost = 26.60;
                        break;
                    case "apartment":
                        cost = 39.80;
                        break;
                }
            }
            
            sum = cost * 4 * nights;
            if (nights>7)
            {
                sum = sum - sum* 0.25;
            }
            Console.WriteLine($"Annie's holiday in the {cruizTipe} sea costs {sum :F2} lv.");

        }
    }
}
