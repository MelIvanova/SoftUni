using System;
using System.Collections.Generic;
using System.Linq;

namespace _702._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input!= "No Money")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                string gift = arguments[1];

                switch (command)
                {
                    case "OutOfStock":
                        while (gifts.Contains(gift))
                        {
                            int index = gifts.IndexOf(gift);
                            gifts[index] = "None";
                        }
                        break;
                    case "Required":
                        int givenIndex = int.Parse(arguments[2]);
                        if (givenIndex>=0 && givenIndex < gifts.Count)
                        {
                            gifts[givenIndex] = gift;
                        }
                        break;
                    case "JustInCase":
                        gifts.RemoveAt(gifts.Count - 1);
                        gifts.Add(gift);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",gifts.Where(x=>x !="None").ToList()));
        }
    }
}
