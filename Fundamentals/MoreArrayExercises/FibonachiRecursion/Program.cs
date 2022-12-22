using System;

namespace FibonachiRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonachiNumber(position));
        }

        private static int GetFibonachiNumber( int position)
        {
            
            if (position == 0)
            {
                return 0;
            }
            if (position == 1 || position == 2)
            {
                return 1;
            }
            int result = GetFibonachiNumber(position - 1) + GetFibonachiNumber(position - 2);
            return result;
        }
    }
}
