using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            string input = Console.ReadLine();
            int indexCount = 0;
            while (input != "No more tires")
            {
                string[] arguments = input.Split();
                tires.Add(new Tire[arguments.Length / 2]);
                int countArray = 0;

                for (int i = 0; i < arguments.Length; i++)
                {
                    int year = int.Parse(arguments[i]);
                    double pressure = double.Parse(arguments[i + 1]);
                    tires[indexCount][countArray] = new Tire(year, pressure);
                    i++;
                    countArray++;
                }

                input = Console.ReadLine();
                indexCount++;
            }

            input = Console.ReadLine();
            List<Engine> engines = new List<Engine>();

            while (input != "Engines done")
            {
                string[] arguments = input.Split();
                int horsePower = int.Parse(arguments[0]);
                double cubicCapasity = double.Parse(arguments[1]);
                engines.Add(new Engine(horsePower, cubicCapasity));
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<Car> showRoom = new List<Car>();

            while (input != "Show special")
            {
                string[] arguments = input.Split();
                string make = arguments[0];
                string model = arguments[1];
                int year = int.Parse(arguments[2]);
                double fuelQuantity = double.Parse(arguments[3]);
                double fuelCapacity = double.Parse(arguments[4]);
                int engineIndex = int.Parse(arguments[5]);
                int tireIndex = int.Parse(arguments[6]);

                showRoom.Add(new Car(make, model, year,
                    fuelQuantity, fuelCapacity, engines[engineIndex], tires[tireIndex]));

                input = Console.ReadLine();
            }

            List<Car> specialCars = SpecialCar(showRoom);

            foreach (var car in specialCars)
            {
                car.Drive(0.2);

                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}" +
                    $"\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }

        static List<Car> SpecialCar(List<Car> showRoom)
        {
            List<Car> special = new List<Car>();

            for (int i = 0; i < showRoom.Count; i++)
            {
                if (showRoom[i].Year >= 2017 && showRoom[i].Engine.HorsePower >= 330)
                {
                    double presureAll = 0;
                    foreach (var tire in showRoom[i].Tires)
                    {
                        presureAll += tire.Pressure;
                    }

                    if (presureAll >= 9 && presureAll <= 10)
                    {
                        special.Add(showRoom[i]);
                    }
                }
            }

            return special;
        }
    }
}
