using System;

namespace _06._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            bool isItFroot = (product == "banana" || product == "apple" || product == "kiwi" || product == "lemon" || product == "grapes" || product == "cherry");
            bool isItVegetable = (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot" );
            if(isItFroot)
            {
                Console.WriteLine("fruit");
            }
            else if (isItVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
                Console.WriteLine("unknown");
        }

    }
}
