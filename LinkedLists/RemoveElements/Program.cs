using System;

namespace RemoveElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Linked List Elements - LeetCode 203");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(4);
            head.next.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next.next = new ListNode(6);

            // ListNode head = new ListNode(7);
            // head.next = new ListNode(7);
            // head.next.next = new ListNode(7);
            // head.next.next.next = new ListNode(7);

            // ListNode result = RemoveElements(head, 7);

            ListNode result = RemoveElements(head, 6);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }

        static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            ListNode current = head;
            ListNode prev = null;

            while (current != null)
            {
                if (current.val == val)
                {
                    if (prev != null)
                    {
                        prev.next = current.next;
                    }
                    else
                    {
                        head = head.next;
                    }
                }
                else
                {
                    prev = current;
                }

                current = current.next;
            }

            return head;
        }
    }
}
