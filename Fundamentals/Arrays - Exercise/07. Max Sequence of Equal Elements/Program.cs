using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int temp = 0;
            int index = 0;
            string number = "";
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    temp++;
                    if (temp > counter)
                    {
                        counter = temp;
                        index = i;
                        number = numbers[i].ToString();
                    }
                }
                else
                {
                    temp = 0;
                }
            }
            for (int i = 0; i <= counter; i++)
            {
                Console.Write(number + " ");
            }
        }
           
            
        }
    }

