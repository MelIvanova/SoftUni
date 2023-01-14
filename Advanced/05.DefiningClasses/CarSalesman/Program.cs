using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Queue<string> engineData = new Queue<string>(input.Split(" ",StringSplitOptions.RemoveEmptyEntries));
                string model = engineData.Dequeue();
                int power = int.Parse(engineData.Dequeue());

                engines.Add(new Engine(model, power));

                int displacement;
                string efficiency;

                while (engineData.Any())
                {

                    if (int.TryParse(engineData.Peek(), out displacement))
                    {
                        displacement = int.Parse(engineData.Dequeue());
                        engines[i].Displacement = displacement;
                    }
                    else
                    {
                        efficiency = engineData.Dequeue();
                        engines[i].Efficiency = efficiency;
                    }
                }
            }

            n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Queue<string> carData = new Queue<string>(input.Split(" ",StringSplitOptions.RemoveEmptyEntries));
                string model = carData.Dequeue();
                string engineModel = carData.Dequeue();
                Engine carEngine = engines.First(e => e.Model == engineModel);
                cars.Add(new Car(model, carEngine));
                int weigth;
                string color;

                while (carData.Any())
                {
                    if (int.TryParse(carData.Peek(), out weigth))
                    {
                        weigth = int.Parse(carData.Dequeue());
                        cars[i].Weight = weigth;
                    }
                    else
                    {
                        color = carData.Dequeue();
                        cars[i].Color = color;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:\n  {car.Engine.Model}:\n    Power: {car.Engine.Power}");
                if (car.Engine.Displacement!=0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine("    Displacement: n/a");
                }

                if (car.Engine.Efficiency != null)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine("    Efficiency: n/a");
                }

                if (car.Weight!=0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine("  Weight: n/a");
                }

                if (car.Color != null)
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine("  Color: n/a");
                }
            }
        }
    }
}
