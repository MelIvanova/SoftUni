using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                cars.Add(new Car());
                cars[i].Model = input[0];
                cars[i].FuelAmount = double.Parse(input[1]);
                cars[i].FuelConsumptionPerKilometer = double.Parse(input[2]);
                cars[i].TravelledDistance = 0;
            }

            string command = Console.ReadLine();

            while (command !="End")
            {
                string[] travelData = command.Split();
                string model = travelData[1];
                double distance = double.Parse(travelData[2]);
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model == model)
                    {
                        cars[i].DriveTheCar(distance);
                    }
                }
                
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance:f0}");
            }
        }
    }
}
