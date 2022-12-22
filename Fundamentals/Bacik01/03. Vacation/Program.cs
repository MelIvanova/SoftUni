using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string typeOfPerson = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            switch (typeOfPerson)
            {
                case "Students":
                    switch (day)
                    {
                        
                        case "Friday":
                            price = 8.45;
                            totalPrice = peopleNum * price;
                            break;
                        case "Saturday":
                            price = 9.80;
                            totalPrice = peopleNum * price;
                            break;
                        case "Sunday":
                            price =  10.46;
                            totalPrice = peopleNum * price;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price =  10.90;
                            totalPrice = peopleNum * price;
                            break;
                        case "Saturday":
                            price =  15.60;
                            totalPrice = peopleNum * price;
                            break;
                        case "Sunday":
                            price = 16;
                            totalPrice = peopleNum * price;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price =  15;
                            totalPrice = peopleNum * price;
                            break;
                        case "Saturday":
                            price = 20;
                            totalPrice = peopleNum * price;
                            break;
                        case "Sunday":
                            price = 22.50;
                            totalPrice = peopleNum * price;
                            break;
                    }
                    break;
            }
            if(typeOfPerson == "Students" && peopleNum >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            if(typeOfPerson == "Business" && peopleNum >= 100)
            {
                totalPrice = totalPrice - (price * 10);
            }
            if (typeOfPerson == "Regular" && peopleNum >= 10 && peopleNum <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
