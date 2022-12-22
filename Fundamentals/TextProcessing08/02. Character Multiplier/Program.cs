using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string fitst = input[0];
            string second = input[1];
            if (fitst.Length < second.Length)
            {
                string curr = fitst;
                fitst = second;
                second = curr;
            }

            int sum = 0;

            for (int i = 0; i < second.Length; i++)
            {
                int charSum = SumChar(fitst[i], second[i]);
                sum += charSum;
            }
            if (fitst.Length > second.Length)
            {
                fitst = fitst.Remove(0, second.Length);
                foreach (char letter in fitst)
                {
                    sum += letter;
                }
            }
            Console.WriteLine(sum);
        }

        private static int SumChar(char v1, char v2)
        {
            int sum = v1 * v2;

            return sum;
        }
    }
}
