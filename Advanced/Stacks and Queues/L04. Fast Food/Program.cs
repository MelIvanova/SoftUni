using System;
using System.Collections.Generic;
using System.Linq;

namespace L04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(input);
            bool notEnought = false;

            Console.WriteLine(orders.Max());

            while (orders.Count>0)
            {

                if (quantity >= orders.Peek())
                {
                    quantity -= orders.Dequeue(); ;
                }
                else
                {
                    notEnought = true;
                    break;
                }
            }

            if (notEnought)
            {
                Console.Write("Orders left: ");
                Console.Write(String.Join(" ", orders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
