using System;
using System.Collections.Generic;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack numbers = new CustomStack();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
            numbers.Push(40);
            numbers.Push(50);

            Console.WriteLine(numbers.Peek());
            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Pop());

            numbers.Select(x => x * 2);

            numbers.ForEach(element => Console.WriteLine(numbers.Pop()));
            
        }
    }
}
