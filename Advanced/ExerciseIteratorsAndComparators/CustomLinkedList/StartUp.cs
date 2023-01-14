using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> students = new DoublyLinkedList<string>();
            ListNode<string> student = new ListNode<string>("Pesho");
            students.AddFirst(student);


        }
    }
}
