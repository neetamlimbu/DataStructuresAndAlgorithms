using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Linked List...");

            LinkedList linkedList = new LinkedList();

            linkedList.AddSorted(7);
            linkedList.AddSorted(10);
            linkedList.AddSorted(9);
            linkedList.AddSorted(6);
            linkedList.AddSorted(8);
            linkedList.AddSorted(1);

            linkedList.Display();

        }


    }
}
