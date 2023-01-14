using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] names = ArrayCreator.Create(5, "Hello");

            Console.WriteLine(String.Join(", ", names));
        }
    }
}
