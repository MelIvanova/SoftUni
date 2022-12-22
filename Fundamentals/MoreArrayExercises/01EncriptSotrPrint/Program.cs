using System;
using System.Linq;

namespace _01EncriptSotrPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] words = new string[num];
            int[] results = new int[num];

            for (int i = 0; i < num; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < num; i++)
            {
                int sum = 0;

                for (int j = 0; j < words[i].Length; j++)
                {
                    string cutrrent = words[i];
                    switch (cutrrent[j])
                    {
                        case 'a':
                        case 'o':
                        case 'i':
                        case 'u':
                        case 'e':
                        case 'A':
                        case 'O':
                        case 'I':
                        case 'U':
                        case 'E':
                            sum += cutrrent[j] * words[i].Length;
                            break;
                        default:
                            sum += cutrrent[j] / words[i].Length;
                            break;
                    }
                }
                results[i] = sum;
            }

            results = results.OrderBy(x => x).ToArray();
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }
           // Console.WriteLine(String.Join(Environment.NewLine, results));
        }
    }
}
