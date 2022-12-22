using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            double result = 0;

            while (comand!="Start")
            {
                double incom = double.Parse(comand);
                switch (incom)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        result += incom;
                            break;
                    default:
                        Console.WriteLine($"Cannot accept {incom}");
                        break;
                }
                comand = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double price = 0;

            while (product!= "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        if (result >= price)
                        {
                            result -= price;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        price = 0.7;
                        if (result >= price)
                        {
                            result -= price;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        price = 1.5;
                        if (result >= price)
                        {
                            result -= price;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        price = 0.8;
                        if (result >= price)
                        {
                            result -= price;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        price = 1;
                        if (result >= price)
                        {
                            result -= price;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {result:F2}");
        }
    }
}
