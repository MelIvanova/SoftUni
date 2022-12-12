using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            int i = 0;
            
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        if (i > 0) 
                        {
                            i--;
                        }
                        
                    }
                    else
                    {
                        i++;
                    }
                
                }
                Console.WriteLine(string.Join(" " , numbers));
        }
    }
}
