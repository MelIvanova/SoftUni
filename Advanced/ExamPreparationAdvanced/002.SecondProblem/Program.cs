using System;
using System.Collections.Generic;
using System.Linq;


namespace _002.SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            List<int> sets = new List<int>();
            int biggestPrice = 0;

            while (hats.Any() && scarfs.Any())
            {
                if (hats.Peek() > scarfs.Peek())
                {
                    int price = hats.Pop() + scarfs.Dequeue();

                    if (biggestPrice < price)
                    {
                        biggestPrice = price;
                    }

                    sets.Add(price);
                }
                else if (hats.Peek() < scarfs.Peek())
                {
                    hats.Pop();
                }
                else if (hats.Peek() == scarfs.Peek())
                {
                    scarfs.Dequeue();
                    int increase = hats.Pop() + 1;
                    hats.Push(increase);
                }
            }

            Console.WriteLine($"The most expensive set is: {biggestPrice}");
            Console.WriteLine(String.Join(" ",sets));
        }
    }
}
