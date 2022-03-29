using System;

namespace DeleteNode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delete Node in a Linked List - LeetCode 237");

            ListNode head = new ListNode(4);
            head.next = new ListNode(5);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(9);

            Console.Write(head.val);
            ListNode current = head.next;

            while (current != null)
            {
                Console.Write(" --> " + current.val);
                current = current.next;
            }

            DeleteNode(head.next);
            Console.WriteLine();
            Console.WriteLine("After deleting node...");
            Console.Write(head.val);
            current = head.next;

            while (current != null)
            {
                Console.Write(" --> " + current.val);
                current = current.next;
            }
        }

        static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
