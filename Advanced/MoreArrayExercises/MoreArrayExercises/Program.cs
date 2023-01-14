using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] words = new string[num];
            int[] results= new int[num];

            for (int i = 0; i < num; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < num; i++)
            {
                int sum = 0;

                for (int j = 0; j < words[i].Length; j++)
                {
                    switch (words[i][j])
                    {
                        case 'a':
                        case 'o':
                        case 'i':
                        case 'u':
                        case 'e':
                            sum += words[i][j] * words[i].Length;
                            break;
                        default:
                            sum += words[i][j] / words[i].Length;
                            break;
                    }
                }
                results[i] = sum;
            }

            results = results.OrderBy(x => x).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, results));
        }
    }
}