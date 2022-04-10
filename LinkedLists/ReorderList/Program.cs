using System;

namespace ReorderList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reorder List - LeetCode 143");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            ReorderList(head);

            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }

        static void ReorderList(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            //Find the mid point
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //Reverse the second half
            ListNode reversed = Reverse(slow);

             //Merge two halfs
            ListNode n1 = head;
            ListNode n2 = reversed;
            ListNode tmp = null;

            while (n2.next != null)
            {
                tmp = n1.next;
                n1.next = n2;
                n1 = tmp;
               
                tmp = n2.next;
                n2.next = n1;
                n2 = tmp;
            }
        }

        static ListNode Reverse(ListNode current)
        {
            ListNode prev = null;
            while (current != null)
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
