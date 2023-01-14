using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Tire
    {
        public Tire(double pressure, int year)
        {
            Pressure = pressure;
            Year = year;      
        }

        public int Year { get; set; }

        public double Pressure { get; set; }
    }
}
