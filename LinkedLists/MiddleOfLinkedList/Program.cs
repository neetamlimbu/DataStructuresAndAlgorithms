using System;

namespace MiddleOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Middle of the Linked List - LeetCode 876");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode middle = MiddleNode(head);
            while(middle != null)
            {
                Console.Write(middle.val + " ");
                middle = middle.next;
            }
        }

        static ListNode MiddleNode(ListNode head)
        {

            if (head == null)
                return null;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
