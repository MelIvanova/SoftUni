using System;
using System.Collections.Generic;
using System.Linq;


namespace A07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIPList = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input[0]>=48 && input[0]<=57)
                {
                    VIPList.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (VIPList.Contains(input))
                {
                    VIPList.Remove(input);
                }
                else if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            int didNotCome = VIPList.Count + regularGuests.Count;

            Console.WriteLine(didNotCome);

            if (VIPList.Any())
            {
                foreach (var guest in VIPList)
                {
                    Console.WriteLine(guest);
                }
            }
            if (regularGuests.Any())
            {
                foreach (var guest in regularGuests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
