using System;
using System.Collections.Generic;
using System.Linq;

namespace _303NeedforSpeed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] cars = Console.ReadLine().Split('|');
            Dictionary<string, List<int>> carsMF = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string name = cars[0];
                int miles = int.Parse(cars[1]);
                int fuel = int.Parse(cars[2]);
                carsMF[name] = new List<int> { miles, fuel };
                if (i<n-1)
                {
                    cars = Console.ReadLine().Split('|');
                }
                
            }

            cars = Console.ReadLine().Split(" : ");
            int maxMiles = 100000;
            int tankMax = 75;
            int minMiles = 10000;

            while (cars[0]!= "Stop")
            {
                string command = cars[0];
                string car = cars[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(cars[2]);
                    int fuel = int.Parse(cars[3]);
                    if (carsMF[car][1]-fuel>=0)
                    {
                        carsMF[car][0] += distance;
                        carsMF[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    if (carsMF[car][0]>=maxMiles)
                    {
                        carsMF.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    int fuelRefuel = int.Parse(cars[2]);
                    if (carsMF[car][1]+fuelRefuel>tankMax)
                    {
                        int refuel = tankMax - carsMF[car][1];
                        carsMF[car][1] = tankMax;
                        Console.WriteLine($"{car} refueled with {refuel} liters");
                    }
                    else
                    {
                        carsMF[car][1] += fuelRefuel;
                        Console.WriteLine($"{car} refueled with {fuelRefuel} liters");
                    }
                }
                else if (command== "Revert")
                {
                    int kilometers = int.Parse(cars[2]);
                    if (carsMF[car][0]-kilometers>=minMiles)
                    {
                        carsMF[car][0] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carsMF[car][0] = minMiles;
                    }
                }

                cars = Console.ReadLine().Split(" : ");
            }

            foreach (var car in carsMF.OrderByDescending(c=>c.Value[0]).ThenBy(c=>c.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
