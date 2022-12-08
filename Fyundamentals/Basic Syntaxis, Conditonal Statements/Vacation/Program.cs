using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfPeple = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            decimal totslPrice = 0;
            if (typeOfPeple == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45m;
                        break;
                    case "Saturday":
                        price = 9.80m;
                        break;
                    case "Sunday":
                        price = 10.46m;
                        break;
                }
                totslPrice = price * people;
                if (people>=30)
                {
                    totslPrice = totslPrice - totslPrice * 0.15m;
                }
            }
            else if (typeOfPeple == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90m;
                        break;
                    case "Saturday":
                        price = 15.60m;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }
               
                if (people>=100)
                {
                    people = people - 10;
                }
                totslPrice = price * people;
            }
            else if (typeOfPeple == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15m;
                        break;
                    case "Saturday":
                        price = 20m;
                        break;
                    case "Sunday":
                        price = 22.50m;
                        break;
                }
                totslPrice = price * people;
                if (people>=10 && people<=20)
                {
                    totslPrice = totslPrice - totslPrice * 0.05m;
                }
            }
            Console.WriteLine($"Total price: { totslPrice:F2}");
        }
    }
}
