using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vihicle> vihicles = new List<Vihicle>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string type = "";
                if (input[0] == "car")
                {
                    type = "Car";
                }
                else
                {
                    type = "Truck";
                }

                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);

                Vihicle vihicle = new Vihicle(type, model, color, horsepower);
                vihicles.Add(vihicle);
                input = Console.ReadLine().Split();
            }

            string modelWhanted = Console.ReadLine();
            StringBuilder print = new StringBuilder();

            while (modelWhanted != "Close the Catalogue")
            {
                Vihicle current = vihicles.First(x => x.Model == modelWhanted);
                print.AppendLine($"Type: {current.Type}");
                print.AppendLine($"Model: {current.Model}");
                print.AppendLine($"Color: {current.Color}");
                print.AppendLine($"Horsepower: {current.Horsepower}");
                modelWhanted = Console.ReadLine();
            }

            Vihicle[] cars = vihicles.Where(x => x.Type == "Car").ToArray();
            Vihicle[] truck = vihicles.Where(x => x.Type == "Truck").ToArray();
            double averageForCars = cars.Sum(x=>x.Horsepower);
            if (cars.Length>0)
            {
                averageForCars = averageForCars / cars.Length;
            }

            print.AppendLine($"Cars have average horsepower of: {averageForCars:F2}.");

            double averageForTruck = truck.Sum(x=>x.Horsepower);

            if (truck.Length>0)
            {
                averageForTruck = averageForTruck / truck.Length;
            }
            
            print.AppendLine($"Trucks have average horsepower of: {averageForTruck:F2}.");

            Console.WriteLine(print.ToString());
        }
    }

    class Vihicle
    {
        public Vihicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

    }
}
