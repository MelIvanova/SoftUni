using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>() ;
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string guests = Console.ReadLine();
                string[] outOrIn = guests.Split();

                if (outOrIn[2] == "not")
                {
                    if (guestList.Contains(outOrIn[0]))
                    {
                        guestList.Remove(outOrIn[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{outOrIn[0]} is not in the list!");
                    }
                    continue;
                }
                if (guestList.Contains(outOrIn[0]) )
                {
                    
                    Console.WriteLine($"{outOrIn[0]} is already in the list!");
                }
                else
                {
                    guestList.Add(outOrIn[0]);
                }
                
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
