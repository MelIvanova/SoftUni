using System;

namespace _04NewHows
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //"Not enough money, you need {нужната сума} leva more."
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
           
            switch(flowers)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.5;
                    break;
            }
            double totalPrice = numberOfFlowers*price;

            if(flowers == "Roses" && numberOfFlowers >80)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (flowers == "Dahlias" && numberOfFlowers > 90)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (flowers == "Tulips" && numberOfFlowers > 80)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (flowers == "Narcissus" && numberOfFlowers < 120)
            {
                totalPrice += totalPrice * 0.15;
            }
            else if (flowers == "Gladiolus" && numberOfFlowers < 80)
            {
                totalPrice += totalPrice * 0.20;
            }
           
           
            if(totalPrice<=budget)
            {
                double moneyLeft = budget-totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {moneyLeft:F2} leva left.");
            }
            else if(totalPrice > budget)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeed:F2} leva more.");
            }
        }
    }
}