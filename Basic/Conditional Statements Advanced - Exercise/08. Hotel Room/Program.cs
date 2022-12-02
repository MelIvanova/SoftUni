using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //Studio: {цена за целият престой} lv.//F2

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment=0;
     
            if(month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if(nights >7 && nights <=14)
                {
                    priceStudio -=priceStudio *0.05;
                    priceApartment = 65;
                }
                else if(nights>14)
                {
                    priceStudio -= priceStudio * 0.3;
                    priceApartment -= priceApartment * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;

                if (nights > 14)
                {
                    priceStudio -= priceStudio * 0.2;
                    priceApartment -= priceApartment * 0.1;
                }

            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;
                if (nights > 14)
                {
                    priceApartment -= priceApartment * 0.1;
                }
            }
            double totalPriceApartment = priceApartment * nights;
            double totalPriceStudio = priceStudio * nights;
            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
