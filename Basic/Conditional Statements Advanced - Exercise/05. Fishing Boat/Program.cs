using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Yes! You have {останалите пари} leva left."
            //"Not enough money! You need {сумата, която не достига} leva."

            int buget = int.Parse(Console.ReadLine());
            string seasone = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double price = 0;
            
            if(seasone == "Spring")
            {
                price = 3000;
                if(people<=6)
                {
                    price -= price * 0.1;
                    if(people%2==0)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (people >= 7 && people <= 11)
                {
                    price -= price * 0.15;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
               else if (people > 12)
                {
                    price -= price * 0.25;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
            }
            else if (seasone == "Summer")
            {
                price = 4200;
                if (people <= 6)
                {
                    price -= price * 0.1;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (people >= 7 && people <= 11)
                {
                    price -= price * 0.15;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (people > 12)
                {
                    price -= price * 0.25;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
            }
            else if (seasone == "Autumn")
            {
                price = 4200;
                if (people <= 6)
                {
                    price -= price * 0.1;
                    
                }
                else if (people >= 7 && people <= 11)
                {
                    price -= price * 0.15;
                    
                }
                else if (people > 12)
                {
                    price -= price * 0.25;
                    
                }
            }
            else if (seasone == "Winter")
            {
                price = 2600;
                if (people <= 6)
                {
                    price -= price * 0.1;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (people >= 7 && people <= 11)
                {
                    price -= price * 0.15;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (people > 12)
                {
                    price -= price * 0.25;
                    if (people % 2 == 0)
                    {
                        price -= price * 0.05;
                    }
                }
            }
            double moneyLeft = buget - price;
            double moneyNeed = price - buget;
            if(buget>=price)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else if (price>buget)
            {
                Console.WriteLine($"Not enough money! You need {moneyNeed:F2} leva.");
            }
        }
    }
}
