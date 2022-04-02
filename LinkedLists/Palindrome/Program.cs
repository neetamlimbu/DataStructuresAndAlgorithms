using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Linked List - LeetCode 234");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(1);

            Console.WriteLine(IsPalindrome(head));
        }

        static bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode firstHalf = head;
            ListNode secondHalf = Reverse(slow.next);

            while (firstHalf != null && secondHalf != null)
            {
                if(firstHalf.val != secondHalf.val)
                {
                    return false;
                }
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }

            return true;
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
