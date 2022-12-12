using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int result = 0;
            if (first.Length < second.Length)
            {
                string temp = first;
                first = second;
                second = temp;
            }
            for (int i = 0; i < first.Length; i++)
            {
                int num = first[i];
                if (i < first.Length && i > second.Length-1)
                {
                    num = first[i];
                    result += num;
                    continue;
                }
              
                int number = second[i];
                result = result + (num * number);

            }
            Console.WriteLine(result);
        }
    }
}
