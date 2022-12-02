using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluate = Console.ReadLine();
            double priceForOneNight = 0;
            int night = days - 1;
           
            double discout = 0;
            if(room == "room for one person")
            {
                priceForOneNight = 18.00;

            }
            else if (room == "apartment")
            {
                priceForOneNight = 25.00;
                if(days<10)
                {
                    discout = 0.30;
                }
                else if (days>=10 && days <=15)
                {
                    discout = 0.35;
                }
                else if (days>15)
                {
                    discout = 0.50;
                }
            }
           else if (room == "president apartment")
            {
                priceForOneNight = 35.00;
                if (days < 10)
                {
                    discout = 0.10;
                }
                else if (days >= 10 && days <= 15)
                {
                    discout = 0.15;
                }
                else if (days > 15)
                {
                    discout = 0.20;
                }
  
            }
            double totalPrice = (priceForOneNight * night);
            totalPrice = totalPrice - totalPrice * discout;
            if (evaluate == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (evaluate == "negative")
            {
                totalPrice -= totalPrice * 0.10;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
        
    }
}
