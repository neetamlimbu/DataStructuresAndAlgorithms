using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Duplicates from Sorted List - LeetCode 83");

            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);

            ListNode result = DeleteDuplicates(head);
            ListNode current = result.next;

            Console.Write(result.val);
            while (current != null)
            {
                Console.Write(" --> " + current.val);
                current = current.next;
            }
        }

        static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return head;

            ListNode current = head;

            while (current != null)
            {
                if (current.next != null && current.val == current.next.val)
                {
                    if (current.next.next != null)
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current.next = null;
                        current = current.next;
                    }
                }
                else
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}
