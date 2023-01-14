using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
   public class Car
    {
        public Car(string model, Engine engin)
        {
            Model = model;
            Engine = engin;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }
    }
}
