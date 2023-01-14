using System;

namespace CustomDoublyLinkedList
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> names = new DoublyLinkedList<int>();

            string[] input = Console.ReadLine().Split(" ");

            names.AddFitst(new Node<int>(int.Parse(input[0])));
            names.AddLast(new Node<int>(int.Parse(input[1])));

            names.ForEach(x => Console.WriteLine(x.Value));

        }
    }
}
