using System;

namespace GenericScale
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> numbers = new EqualityScale<int>(4, 5);

            Console.WriteLine(numbers.AreEqual());
        }
    }
}
