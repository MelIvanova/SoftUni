using System;

namespace ARRAYS03
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int [] train = new int[wagons];
            int allPeople = 0;

            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                allPeople += train[i];
                
            }
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(allPeople);
        }
    }
}
