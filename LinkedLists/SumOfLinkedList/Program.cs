using System;

namespace sumoflinkedlist
{
    //You are given two non-empty linked lists representing two non-negative integers. 
    //The digits are stored in reverse order, and each of their nodes contains a single digit. 
    //Add the two numbers and return the sum as a linked list.
    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    class Program
    {
        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two linked list nodes");

            ListNode l1 = new ListNode(9, null);    // 2 4 3
            l1.next = new ListNode(9, null);        // 5 6 4
            l1.next.next = new ListNode(9, null);   // 7 0 8
            l1.next.next.next = new ListNode(9, null);
            l1.next.next.next.next = new ListNode(9, null);
            l1.next.next.next.next.next = new ListNode(9, null);
            l1.next.next.next.next.next.next = new ListNode(9, null);

            ListNode l2 = new ListNode(9, null);
            l2.next = new ListNode(9, null);
            l2.next.next = new ListNode(9, null);
            l2.next.next.next = new ListNode(9, null);

            ListNode resultNode = AddTwoNumbers(l1, l2);
            Console.Write("[");
            while (resultNode != null)
            {
                Console.Write(resultNode.val + " ");
                resultNode = resultNode.next;
            }
            Console.Write("]");
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = null; //Head of the resultant linked list
            ListNode prev = null;
            ListNode temp = null;
            int sum, carryOver = 0;

            while (l1 != null || l2 != null)
            {
                sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carryOver;
                carryOver = sum >= 10 ? 1 : 0;
                sum = sum % 10; //For example, if sum is 18, 8 is the sum and 1 is the carry over to the next sum

                temp = new ListNode(sum, null);

                if (res == null)
                {
                    res = temp;
                    prev = res;
                }
                else
                {
                    prev.next = temp;
                    prev = prev.next;
                }

                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if (carryOver > 0)
            {
                prev.next = new ListNode(carryOver, null);
            }

            return res;
        }
    }
}
