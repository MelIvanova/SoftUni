using System;
using System.Collections.Generic;
using System.Linq;

namespace L07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue <int> distance = new Queue<int>();
            Queue<int> capacity = new Queue<int>();


            for (int i = 0; i < n; i++)
            {
                int [] pumpInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int petrol = pumpInfo[0];
                int kilometers = pumpInfo[1];
                distance.Enqueue(kilometers);
                capacity.Enqueue(petrol);
            }

            for (int i = 0; i < n; i++)
            {
                int row = 0;
                bool success = true;

                for (int j = 0; j < n; j++)
                {
                    int amount = capacity.Dequeue();
                    capacity.Enqueue(amount);
                    int kilometers = distance.Dequeue();
                    distance.Enqueue(kilometers);
                    row += amount - kilometers;

                    if (row<0)
                    {
                        success = false;
                    }
                }

                if (success)
                {
                    Console.WriteLine(i);
                    break;
                }

                int currFule = capacity.Dequeue();
                capacity.Enqueue(currFule);
                int currDistance = distance.Dequeue();
                distance.Enqueue(currDistance);
            }
         

        }
    }
}
