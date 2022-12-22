using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            bool isBigger = false;

            for (int i = 0; i < range.Length; i++)
            {
                for (int j = 0 + i ;j < range.Length-i; j ++)
                {
                    if (range[i]<=range[j])
                    {
                        isBigger = false;
                        continue;
                    }
                    else
                    {
                        isBigger = true;
                    }

                }

                if (isBigger)
                {
                    if (i==range.Length-1)
                    {
                        result += range[i];
                    }
                    else
                    {
                        result += range[i] + " ";
                    }
                    
                }
            }
        }
    }
}
