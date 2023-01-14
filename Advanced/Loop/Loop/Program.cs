using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                sequence[i] = element;
            }

            int count = 0;
            int max = 0;

            for (int i = 0; i < n-1; i++)
            {
                int curr = sequence[i];

                if (curr == sequence[i+1])
                {
                    count++;
                }
                else
                {
                    count++;
                    if (max<count)
                    {
                        max = count;
                    }

                    count = 0;
                }
            }
            if (max == 0)
            {
                count++;
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(max);
            }
            
           
        }
    }
}
