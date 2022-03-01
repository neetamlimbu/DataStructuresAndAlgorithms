using System;

namespace CustomLinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "| ->");
            if(next != null)
            {
                next.Print();
            }
            else
            {
                Console.Write(" |null|");
            }
        }

        public void Add(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.Add(data);
            }
        }

        public void AddSorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if(data > next.data)
            {
                next.AddSorted(data);
            }
            else if(data < next.data)
            {
                Node temp = new Node(data);
                temp.next = next;
                next = temp;
            }
        }
    }
}
