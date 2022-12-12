using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input!="Start")
            {
                double money = double.Parse(input);
                if (money==0.1|| money==0.2|| money==0.5|| money==1|| money==2)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine();
            }
            string purchase = Console.ReadLine();
            double value = 0;
            while (purchase != "End")
            {


                switch (purchase)
                {
                    case "Nuts":
                        if (sum < 2.0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        value = 2.0;
                        Console.WriteLine("Purchased nuts");
                        break;
                    case "Water":
                        if (sum < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        value = 0.7;
                        Console.WriteLine("Purchased water");
                        break;
                    case "Crisps":
                        if (sum < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        value = 1.5;
                        Console.WriteLine("Purchased crisps");
                        break;
                    case "Soda":
                        if (sum < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        value = 0.8;
                        Console.WriteLine("Purchased soda");
                        break;
                    case "Coke":
                        if (sum < 1.0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        value = 1.0;
                        Console.WriteLine("Purchased coke");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sum>=value)
                {
                    sum -= value;
                }
              
                purchase = Console.ReadLine();

            }
                
            Console.WriteLine($"Change: {sum:f2}");
        }
            
        }
    }

