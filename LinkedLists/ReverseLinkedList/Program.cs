using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Linked List - Leetcode 206");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode reversed = ReverseList(head);
            Console.Write(reversed.val);

            ListNode current = reversed.next;
            while(current != null)
            {
                Console.Write(" -> " + current.val);
                current = current.next;
            }
        }

        static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return head;

            ListNode current = head;
            ListNode prev = null;

            while(current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
