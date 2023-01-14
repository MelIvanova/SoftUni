using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                int speed = int.Parse(data[1]);
                int power = int.Parse(data[2]);
                int weight = int.Parse(data[3]);
                string type = data[4];
                double presureOne = double.Parse(data[5]);
                int ageOne = int.Parse(data[6]);
                double presureTwo = double.Parse(data[7]);
                int ageTwo = int.Parse(data[8]);
                double presureThree = double.Parse(data[9]);
                int ageThree = int.Parse(data[10]);
                double presureFour = double.Parse(data[11]);
                int ageFour = int.Parse(data[12]);

                cars.Add(new Car(model, new Engine(speed, power), new Cargo(weight, type),
                    new Tire[]
                    {
                        new Tire(presureOne, ageOne),
                        new Tire(presureTwo, ageTwo),
                        new Tire(presureThree, ageThree),
                        new Tire(presureFour, ageFour)
                    }));
            }

            string command = Console.ReadLine();

            cars = cars.Where(c => c.Cargo.Type == command).ToList();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {

                    foreach (var tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }



        }
    }
}
