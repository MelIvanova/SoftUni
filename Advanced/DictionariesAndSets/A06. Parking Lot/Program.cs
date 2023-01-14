using System;
using System.Collections.Generic;
using System.Linq;

namespace A06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkilgLot = new HashSet<string>();
            string[] carStreem = Console.ReadLine().Split(", ");
            string command = carStreem[0];

            while (command!= "END")
            {
                string licenceNumber = carStreem[1];

                if (command == "IN")
                {
                    parkilgLot.Add(licenceNumber);
                }
                else
                {
                    if (parkilgLot.Contains(licenceNumber))
                    {
                        parkilgLot.Remove(licenceNumber);
                    }
                }

                carStreem = Console.ReadLine().Split(", ");
                command = carStreem[0];
            }

            if (parkilgLot.Any())
            {
                foreach (var number in parkilgLot)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
